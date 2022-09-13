
using AutoMapper;
using Microsoft.Extensions.Options;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly IEmailService _emailService;
        private readonly IErrorLogService _errorLogService;
        private readonly ITokenService _tokenService;
        private ServiceResponse<Staff> _response;
        private RepositoryResponse<Staff> _repositoryResponse;

        public AccountService(
            IUnitOfWork uow,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IEmailService emailService,
            IErrorLogService errorLogService,
            TokenService tokenService
            
            )
        {
            _uow = uow;
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _emailService = emailService;
            _errorLogService = errorLogService;
            _tokenService = tokenService;
            _response = new ServiceResponse<Staff>();
            _repositoryResponse = new RepositoryResponse<Staff>();
        }

        public async Task<RegisterResponse> RegisterAsync(RegisterRequest request)
        {
            RegisterResponse response = new RegisterResponse();
    
            _repositoryResponse = await _uow.Repository<Staff>().FindAsync(user => user.EmailAddress == request.EmailAddress);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "RegisterAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = 0,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to register.";
                return response;
            }

            if (_repositoryResponse.Entity != null)
            {
                return new RegisterResponse
                {
                    Success = false,
                    Message = "User already exists.",
                };
            }

            var salt = Helper.GetSecureSalt();
            var passwordHash = Helper.HashUsingPbkdf2(request.Password, salt);

            Staff staff = new Staff(request.EmailAddress);
            staff.FirstName = request.FirstName;
            staff.LastName = request.LastName;
            staff.Address = request.Address;
            staff.Address2 = request.Address2;
            staff.City = request.City;
            staff.State = request.State;
            staff.PostalCode = request.PostalCode;
            staff.Country = request.Country;
            staff.PhoneNumber = request.PhoneNumber;
            staff.EmailAddress = request.EmailAddress;
            staff.PhoneNumber = request.EmailAddress;
            //staff.RoleId = request.RoleId;
            staff.Gender = request.EmailAddress;
            staff.FirstAid = request.FirstAid;
            staff.CPR = request.CPR;
            staff.Kriyaban = request.Kriyaban;
            staff.LessonStudent = request.LessonStudent;
            staff.AcceptTerms = request.AcceptTerms;
            staff.CreatedDate = DateTime.UtcNow;
            staff.Password = passwordHash;
            staff.PasswordSalt = Convert.ToBase64String(salt);

            _repositoryResponse = await _uow.Repository<Staff>().AddAsync(staff);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "RegisterAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = 0,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to register.";
                return response;
            }

            if (_repositoryResponse.Entity != null)
            {
                await _emailService.SendEmail(staff, 0, EnumHelper.EmailTypeEnum.RegisterEmail);
                return new RegisterResponse { Success = true, Message = "Registration successful." };
            }
            else
            {
                response.Success = false;
                response.Message = "Registration unsuccessful.";
                return response;
            }
        }

        public async Task<TokenResponse> LoginAsync(LoginRequest request)
        {
            TokenResponse response = new TokenResponse();

            _repositoryResponse = _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == request.EmailAddress && x.IsActive && x.IsVerified).Result;

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "LoginAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = request.PropertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to login.";
                return response;
            }

            if (_repositoryResponse.Entity == null)
            {
                return new TokenResponse
                {
                    Success = false,
                    Message = "User is not found.",
                };
            }

            var propertyStaff = _uow.Repository<PropertyStaff>().FindAsync(x => x.PropertyId == request.PropertyId && x.StaffId == _repositoryResponse.Entity.StaffId).Result;

            if (propertyStaff == null)
            {
                return new TokenResponse
                {
                    Success = false,
                    Message = "User is not found.",
                };
            }

            var passwordHash = Helper.HashUsingPbkdf2(request.Password, Convert.FromBase64String(_repositoryResponse.Entity.PasswordSalt));

            if (_repositoryResponse.Entity.Password != passwordHash)
            {
                return new TokenResponse
                {
                    Success = false,
                    Message = "User is not found.",
                };
            }

            var token = await Task.Run(() => _tokenService.GenerateTokensAsync(_repositoryResponse.Entity.StaffId));
            var property = _uow.Repository<Property>().FindAsync(x => x.PropertyId == request.PropertyId).Result;
            var roleStaff = _uow.Repository<RoleStaff>().FindAsync(x => x.PropertyId == request.PropertyId && x.StaffId == _repositoryResponse.Entity.StaffId).Result;
            var role = _uow.Repository<Role>().FindAsync(x => x.RoleId == roleStaff.Entity.RoleId).Result;

            return new TokenResponse
            {
                Success = true,
                AccessToken = token.Item1,
                RefreshToken = token.Item2,
                FirstName = _repositoryResponse.Entity.FirstName,
                LastName = _repositoryResponse.Entity.LastName,
                IsAdmin = role.Entity.Name == "Admin" ? true : false,
                StaffId = _repositoryResponse.Entity.StaffId,
                PropertyId = request.PropertyId,
                PropertyName = property.Entity.Name
            };
        }

        public async Task<ServiceResponse<Staff>> VerifyEmailAddressAsync(VerifyEmailAddressRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            Staff? staff = null;

            _repositoryResponse = await _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == request.EmailAddress);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "VerifyEmailAddressAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = request.PropertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to verify email address.";
                return response;
            }

            if (_repositoryResponse.Entity.IsVerified)
            {
                response.Message = "Email successfully verified.";
                response.Success = true;

                return response;
            }

            if (_repositoryResponse.Entity == null)
            {
                response.Message = "Email verification failed.";
                response.Success = false;

                return response;
            }

            staff.VerifiedDate = DateTime.UtcNow;
            staff.IsVerified = true;
            staff.IsActive = true;
            staff.EmailConfirmed = true;

            _repositoryResponse = await _uow.Repository<Staff>().UpdateAsync(staff);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "VerifyEmailAddressAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = request.PropertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

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

            _repositoryResponse = await _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == request.EmailAddress && x.PostalCode == request.PostalCode);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "ForgotPasswordAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = request.PropertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to verify email address.";
                return response;
            }

            if (_repositoryResponse.Entity == null)
            {
                response.Message = "User not found.";
                response.Success = false;

                return response;
            }

            var propertyStaff = _uow.Repository<PropertyStaff>().FindAsync(x => x.PropertyId == request.PropertyId && x.StaffId == _repositoryResponse.Entity.StaffId).Result;

            if (propertyStaff == null)
            {
                response.Message = "User not found.";
                response.Success = false;

                return response;
            }

            _repositoryResponse.Entity.UpdatedBy = request.EmailAddress;
            _repositoryResponse.Entity.UpdatedDate = DateTime.UtcNow;

            _repositoryResponse = await _uow.Repository<Staff>().UpdateAsync(_repositoryResponse.Entity);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "ForgotPasswordAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = request.PropertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to verify email address.";
                return response;
            }

            await _emailService.SendEmail(_repositoryResponse.Entity, request.PropertyId, EnumHelper.EmailTypeEnum.ResetPassword);

            response.Message = "Email successfully sent.";
            response.Success = true;

            return response;
        }

        public async Task<ServiceResponse<Staff>> ResetPasswordAsync(ResetPasswordRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            var _repositoryResponse = await _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == request.EmailAddress);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "ResetPasswordAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = request.PropertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to reset password.";
                return response;
            }

            if (_repositoryResponse.Entity == null)
            {
                response.Message = "User not found.";
                response.Success = false;

                return response;
            }

            var passwordHash = Helper.HashUsingPbkdf2(request.OldPassword, Convert.FromBase64String(_repositoryResponse.Entity.PasswordSalt));

            if (_repositoryResponse.Entity.Password != passwordHash)
            {
                response.Message = "Old password is incorrect.";
                response.Success = false;

                return response;
            }

            _repositoryResponse.Entity.UpdatedDate = DateTime.UtcNow;
            _repositoryResponse.Entity.UpdatedBy = request.EmailAddress;
            _repositoryResponse.Entity.Password = Helper.GetPasswordHash(request.NewPassword, request.EmailAddress);
            _repositoryResponse.Entity.PasswordReset = DateTime.UtcNow;

            _repositoryResponse = await _uow.Repository<Staff>().UpdateAsync(_repositoryResponse.Entity);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "ResetPasswordAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = request.PropertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

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

            _repositoryResponse = await _uow.Repository<Staff>().FindAsync(x => x.StaffId == id);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "ResetPasswordAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });

                response.Success = false;
                response.Message = "Unable to reset password.";
                return response;
            }

            response.Success = true;
            response.Message = "GetStaff successful.";
            response.Data = _repositoryResponse.Entity;
            return response;
        }

        public async Task<int> RecordLoginAttempts(string userId, int propertyId)
        {
            _repositoryResponse = await _uow.Repository<Staff>().RecordLoginAttempts(userId);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "GetStaffAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Count;
        }

        public async Task<bool> ResetLoginAttempts(string userId, int propertyId)
        {
            _repositoryResponse = await _uow.Repository<Staff>().ResetLoginAttempts(userId);

            if (_repositoryResponse.Error != null)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "GetStaffAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Result;

        }
        #endregion
    }
}
