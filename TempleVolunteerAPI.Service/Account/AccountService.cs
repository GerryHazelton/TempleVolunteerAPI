
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class AccountService : IAccountService
    {
        private readonly IRepositoryWrapper _uow;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly IRoleService _roleService;
        private readonly IEmailService _emailService;
        private readonly ITokenService _tokenService;
        private ServiceResponse<Staff> _response;
        private RepositoryResponse<Staff> _repositoryResponse;
        private bool _result;

        public AccountService(
            IRepositoryWrapper uow,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IRoleService roleService,
            IEmailService emailService,
            ITokenService tokenService,
            IStaffRepository staffRepository)
        {
            _uow = uow;
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _emailService = emailService;
            _roleService = roleService;
            _tokenService = tokenService;
            _response = new ServiceResponse<Staff>();
            _repositoryResponse = new RepositoryResponse<Staff>();
        }

        public async Task<RegisterResponse> RegisterAsync(Staff staff)
        {
            RegisterResponse response = new RegisterResponse();
            var salt = Helper.GetSecureSalt();
            var tempPwd = CreateTempPassword(staff);
            var passwordHash = Helper.HashUsingPbkdf2(tempPwd, salt);

            staff.Password = passwordHash;
            staff.PasswordSalt = Convert.ToBase64String(salt);
            staff = _uow.Staff.CreateStaff(staff, staff.PropertyId, staff.EmailAddress);
            Role role = _roleService.FindByCondition(x => x.Name == "Volunteer" && x.PropertyId == staff.PropertyId, staff.PropertyId, staff.EmailAddress, EnumHelper.WithDetails.No).FirstOrDefault();
            staff.Roles.Add(new StaffRole() { Staff = staff, StaffId = staff.StaffId, Role = role, RoleId = role.RoleId, PropertyId = staff.PropertyId });
            _uow.Staff.UpdateStaff(staff, staff.PropertyId, staff.EmailAddress);

            if (staff == null)
            {
                response.Success = false;
                response.Message = "Unable to register.";
                return response;
            }

            AddTemporaryPassword(staff.StaffId, tempPwd);
            await _emailService.SendEmail(staff, EnumHelper.EmailTypeEnum.RegisterEmail);
            
            return new RegisterResponse { Success = true, Message = "Registration successful." };
        }
        public async Task<TokenResponse> LoginAsync(LoginRequest request)
        {
            TokenResponse response = new TokenResponse();

            var staff = _uow.Staff.GetStaffWithDetails(x=>x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress, EnumHelper.WithDetails.Yes).FirstOrDefault();

            if (staff == null)
            {
                return new TokenResponse
                {
                    Success = false,
                    Message = "User is not found.",
                };
            }

            var passwordHash = Helper.HashUsingPbkdf2(request.Password, Convert.FromBase64String(staff.PasswordSalt));

            if (staff.Password != passwordHash)
            {
                return new TokenResponse
                {
                    Success = false,
                    Message = "User is not found.",
                };
            }

            var token = await Task.Run(() => _tokenService.GenerateTokensAsync(staff.StaffId, request.PropertyId));
            Domain.Property property = _uow.Properties.FindByCondition(x => x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress).FirstOrDefault();
            bool isAdmin = staff.Roles.Any(x => x.RoleId == 1);
 
            return new TokenResponse
            {
                Success = true,
                AccessToken = token.Item1,
                RefreshToken = token.Item2,
                FirstName = staff.FirstName,
                LastName = staff.LastName,
                IsAdmin = isAdmin,
                StaffId = staff.StaffId,
                PropertyId = request.PropertyId,
                PropertyName = property.Name,
                TemporaryPasswordExists = staff.NewRegistration
            };
        }

        public async Task<RepositoryResponse<MyProfileRequest>> MyProfileAsync(MyProfileRequest request)
        {
            RepositoryResponse<MyProfileRequest> response = new RepositoryResponse<MyProfileRequest>();
            _uow.Staff.CustomMyProfileUpdate(request);
            response.Result = true;
            return response;
        }

        public async Task<ServiceResponse<Staff>> VerifyEmailAddressAsync(VerifyEmailAddressRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            Staff staff = _uow.Staff.GetStaffByMatch(x=>x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress).FirstOrDefault();

            if (staff == null)
            {
                response.Success = false;
                response.Message = "Unable to verify email address.";
                return response;
            }

            if (staff != null && staff.EmailConfirmed)
            {
                response.Message = "Email successfully verified.";
                response.Success = true;

                return response;
            }
            else
            {
                response.Message = "Email verification failed.";
                response.Success = false;

                return response;
            }
        }

        public async Task<ServiceResponse<Staff>> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            Staff staff = _uow.Staff.GetStaffByMatch(x => x.EmailAddress == request.EmailAddress && x.PostalCode == request.PostalCode && x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress).FirstOrDefault();

            if (staff == null)
            {
                response.Success = false;
                response.Message = "Unable to verify email address.";
                return response;
            }

            staff.UpdatedBy = request.EmailAddress;
            staff.UpdatedDate = DateTime.UtcNow;

            _result = _uow.Staff.UpdateStaff(staff, request.PropertyId, request.UpdatedBy);

            if (!_result)
            {
                response.Success = false;
                response.Message = "Unable to verify email address.";
                return response;
            }

            await _emailService.SendEmail(staff, EnumHelper.EmailTypeEnum.ForgotPassword);

            response.Message = "Email successfully sent.";
            response.Success = true;

            return response;
        }

        public async Task<ServiceResponse<Staff>> ResetForgotenPasswordAsync(ResetForgottenPasswordRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            Staff staff = _uow.Staff.GetStaffByMatch(x => x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress).FirstOrDefault();

            if (staff == null)
            {
                response.Message = "User not found.";
                response.Success = false;

                return response;
            }

            var salt = Helper.GetSecureSalt();
            var passwordHash = Helper.HashUsingPbkdf2(request.Password, salt);

            staff.UpdatedDate = DateTime.UtcNow;
            staff.UpdatedBy = request.EmailAddress;
            staff.Password = passwordHash;
            staff.PasswordSalt = Convert.ToBase64String(salt);
            staff.PasswordReset = DateTime.UtcNow;
            _result = _uow.Staff.UpdateStaff(staff, request.PropertyId, request.EmailAddress);

            if (_repositoryResponse.Error != null)
            {
                response.Success = false;
                response.Message = "Unable to reset password.";
                return response;
            }

            response.Message = "Password successfully reset.";
            response.Success = true;

            return response;

        }

        public async Task<ServiceResponse<Staff>> ResetPasswordAsync(ResetPasswordRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            Staff staff = _uow.Staff.GetStaffByMatch(x => x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress).FirstOrDefault();

            if (staff == null)
            {
                response.Message = "User not found.";
                response.Success = false;

                return response;
            }

            var passwordHash = Helper.HashUsingPbkdf2(request.OldPassword, Convert.FromBase64String(staff.PasswordSalt));

            if (staff.Password != passwordHash)
            {
                response.Message = "Old password is incorrect.";
                response.Success = false;

                return response;
            }

            var salt = Helper.GetSecureSalt();
            passwordHash = Helper.HashUsingPbkdf2(request.NewPassword, salt);

            staff.UpdatedDate = DateTime.UtcNow;
            staff.UpdatedBy = request.EmailAddress;
            staff.Password = passwordHash;
            staff.PasswordSalt = Convert.ToBase64String(salt);
            staff.PasswordReset = DateTime.UtcNow;
            staff.NewRegistration = false;
            _result = _uow.Staff.UpdateStaff(staff, request.PropertyId, request.EmailAddress);

            if (!_result)
            {
                response.Success = false;
                response.Message = "Unable to reset password.";
                return response;
            }

            response.Message = "Password successfully reset.";
            response.Success = true;

            return response;
        }

        #region Helpers
        private async Task<ServiceResponse<Staff>> GetStaffAsync(int id, string userId, int propertyId)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            Staff staff = _uow.Staff.GetStaffByMatch(x => x.StaffId == id, propertyId, userId).FirstOrDefault();

            if (staff == null)
            {
                response.Success = false;
                response.Message = "Unable to reset password.";
                return response;
            }

            response.Success = true;
            response.Message = "GetStaff successful.";
            response.Data = staff;
            return response;
        }

        public async Task RecordLoginAttempts(string userId, int propertyId)
        {
            _uow.Staff.RecordLoginAttempts(userId, propertyId);
        }

        public async Task ResetLoginAttempts(string userId, int propertyId)
        {
            _uow.Staff.ResetLoginAttempts(userId, propertyId);
        }

        private string GetRandomChar()
        {
            string[] chars = new string[11] { "!", "@", "#", "$", "%", "^", "&", "*", "?", "+", "=" };
            Random rand = new Random();
            return chars[rand.Next(0, 10)];
        }

        private string CreateTempPassword(Staff staff)
        {
            Random rand = new Random();
            string tempPwd = string.Format("{0}{1}{2}{3}", staff.FirstName, GetRandomChar(), staff.LastName, rand.Next(0, 1000));
            return tempPwd;
        }

        public void AddTemporaryPassword(int staffId, string password)
        {
            _uow.Account.AddTemporaryPassword(staffId, password);
        }

        public string GetTemporaryPassword(int staffId)
        {
            string tempPwd = _uow.Account.GetTemporaryPassword(staffId);

            return tempPwd; 
        }

        public void DeleteTemporaryPassword(int staffId)
        {
            _uow.Account.DeleteTemporaryPassword(staffId);
        }
        #endregion
    }
}
