
using AutoMapper;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;
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
        private readonly IEmailService _emailService;
        private readonly ITokenService _tokenService;
        private ServiceResponse<Staff> _response;
        private RepositoryResponse<Staff> _repositoryResponse;
        private bool _result;

        public AccountService(
            IRepositoryWrapper uow,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IEmailService emailService,
            ITokenService tokenService,
            IStaffRepository staffRepository)
        {
            _uow = uow;
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _emailService = emailService;
            _tokenService = tokenService;
            _response = new ServiceResponse<Staff>();
            _repositoryResponse = new RepositoryResponse<Staff>();
        }

        public async Task<RegisterResponse> RegisterAsync(Staff staff)
        {
            RegisterResponse response = new RegisterResponse();
            var salt = Helper.GetSecureSalt();
            var passwordHash = Helper.HashUsingPbkdf2(staff.Password, salt);

            staff.Password = passwordHash;
            staff.PasswordSalt = Convert.ToBase64String(salt);
            staff = _uow.Staff.CreateStaff(staff, staff.PropertyId, staff.EmailAddress);

            if (staff == null)
            {
                response.Success = false;
                response.Message = "Unable to register.";
                return response;
            }

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
            Property property = _uow.Properties.FindByCondition(x => x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress).FirstOrDefault();
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
                PropertyName = property.Name
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

            if (staff != null && staff.IsVerified)
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

            staff.VerifiedDate = DateTime.UtcNow;
            staff.IsVerified = true;
            staff.IsActive = true;
            staff.EmailConfirmed = true;

            _result = _uow.Staff.UpdateStaff(staff, (int)staff.PropertyId, staff.EmailAddress);

            if (!_result)
            {
                response.Success = false;
                response.Message = "Unable to verify email address.";
                return response;
            }

            response.Message = "Email successfully verified.";
            response.Success = true;

            return response;
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
        #endregion
    }
}
