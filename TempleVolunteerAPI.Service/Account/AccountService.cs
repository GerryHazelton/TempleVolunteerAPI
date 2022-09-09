
using AutoMapper;
using Microsoft.Extensions.Options;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
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

        public AccountService(
            IUnitOfWork uow,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IEmailService emailService,
            IErrorLogService errorLogService,
            ITokenService tokenService
            )
        {
            _uow = uow;
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _emailService = emailService;
            _errorLogService = errorLogService;
            _tokenService = tokenService;
        }

        public async Task<RegisterResponse> RegisterAsync(RegisterRequest request)
        {
            RegisterResponse response = new RegisterResponse();
    
            try
            {
                var existingUser = await _uow.Repository<Staff>().FindAsync(user => user.EmailAddress == request.EmailAddress);

                if (existingUser != null)
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
                staff.CreatedDate = DateTime.Now;
                staff.Password = passwordHash;
                staff.PasswordSalt = Convert.ToBase64String(salt);

                bool addSuccess = await _uow.Repository<Staff>().AddAsync(staff);

                if (addSuccess)
                {
                    await _emailService.SendVerificationEmail(staff);
                    return new RegisterResponse { Success = true };
                }

                return new RegisterResponse
                {
                    Success = false,
                    Message = "Unable to register.",
                };
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "RegisterAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = request.EmailAddress
                });

                response.Success = false;
                response.Message = "Internal exception thrown.";
                return response;
            }
        }

        public async Task<TokenResponse> LoginAsync(LoginRequest request)
        {
            TokenResponse response = new TokenResponse();

            try
            {
                var staff = _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == request.EmailAddress && x.IsActive && x.IsVerified).Result;

                if (staff == null)
                {
                    return new TokenResponse
                    {
                        Success = false,
                        Message = "User is not found.",
                    };
                }

                var propertyStaff = _uow.Repository<PropertyStaff>().FindAsync(x => x.PropertyId == request.PropertyId && x.StaffId == staff.StaffId).Result;

                if (propertyStaff == null)
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

                var token = await Task.Run(() => _tokenService.GenerateTokensAsync(staff.StaffId));
                var property = _uow.Repository<Property>().FindAsync(x => x.PropertyId == request.PropertyId).Result;
                var roleStaff = _uow.Repository<RoleStaff>().FindAsync(x => x.PropertyId == request.PropertyId && x.StaffId == staff.StaffId).Result;
                var role = _uow.Repository<Role>().FindAsync(x => x.RoleId == roleStaff.RoleId).Result;

                return new TokenResponse
                {
                    Success = true,
                    AccessToken = token.Item1,
                    RefreshToken = token.Item2,
                    FirstName = staff.FirstName,
                    LastName = staff.LastName,
                    IsAdmin = role.Name == "Admin" ? true : false,
                    StaffId = staff.StaffId,
                    PropertyId = request.PropertyId,
                    PropertyName = property.Name
                };
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "AuthenticateAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = request.EmailAddress
                });

                response.Success = false;
                response.Message = "Internal exception thrown.";
                return response;
            }
        }

        public async Task<ServiceResponse<Staff>> VerifyEmailAddressAsync(string emailAddress, string token)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            try
            {
                Staff? staff = null;

                if (!String.IsNullOrEmpty(token))
                {
                    staff = await _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == emailAddress);
                }
                else
                {
                    staff = await _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == emailAddress);
                }

                if (staff.IsVerified)
                {
                    response.Message = "Email successfully verified.";
                    response.Success = true;

                    return response;
                }

                if (staff == null)
                {
                    response.Message = "Email verification failed.";
                    response.Success = false;

                    return response;
                }

                staff.VerifiedDate = DateTime.UtcNow;
                staff.IsVerified = true;
                staff.IsActive = true;
                staff.EmailConfirmed = true;

                await _uow.Repository<Staff>().UpdateAsync(staff);

                response.Message = "Email successfully verified.";
                response.Success = true;

                return response;
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "VerifyEmailAddressAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = emailAddress
                });

                response.Success = false;
                response.Message = "Internal exception thrown.";
                return response;
            }
        }

        public async Task<ServiceResponse<Staff>> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            try
            {
                Staff staff = await _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == request.EmailAddress && x.PostalCode == request.PostalCode);

                if (staff == null)
                {
                    response.Message = "User not found.";
                    response.Success = false;

                    return response;
                }

                var propertyStaff = _uow.Repository<PropertyStaff>().FindAsync(x => x.PropertyId == request.PropertyId && x.StaffId == staff.StaffId).Result;

                if (propertyStaff == null)
                {
                    response.Message = "User not found.";
                    response.Success = false;

                    return response;
                }

                staff.UpdatedBy = request.EmailAddress;
                staff.UpdatedDate = DateTime.UtcNow;

                await _uow.Repository<Staff>().UpdateAsync(staff);
                bool result = await _emailService.SendPasswordResetEmail(staff);

                if (result)
                {
                    response.Message = "Email successfully sent.";
                    response.Success = true;
                }
                else
                {
                    response.Message = "User not found.";
                    response.Success = false;
                }

                return response;
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "ForgotPasswordAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = request.EmailAddress
                });

                response.Success = false;
                response.Message = "Internal exception thrown.";
                return response;
            }
        }

        public async Task<ServiceResponse<Staff>> ResetPasswordAsync(ResetPasswordRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            try
            {
                var staff = await _uow.Repository<Staff>().FindAsync(x => x.EmailAddress == request.EmailAddress);

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

                staff.UpdatedDate = DateTime.UtcNow;
                staff.UpdatedBy = request.EmailAddress;
                staff.Password = Helper.GetPasswordHash(request.NewPassword, request.EmailAddress);
                staff.PasswordReset = DateTime.UtcNow;

                await _uow.Repository<Staff>().UpdateAsync(staff);

                response.Message = "Password successfully reset.";
                response.Success = true;

                return response;
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "ResetPasswordAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = request.EmailAddress
                });

                response.Success = false;
                response.Message = "Internal exception thrown.";
                return response;
            }
        }

        #region Helpers
        private async Task<Staff> GetStaffAsync(int id, string userId)
        {
            try
            {
                Staff staff = await _uow.Repository<Staff>().FindAsync(x => x.StaffId == id);

                if (staff == null)
                {
                    throw new KeyNotFoundException("Staff not found (Service: GetStaffAsync)");
                }

                return staff;
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "GetStaffAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = userId
                });

                throw;
            }
        }

        public async Task<int> RecordLoginAttempts(string userId)
        {
            try
            {
                return await _uow.Repository<Staff>().RecordLoginAttempts(userId);
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "GetStaffAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = userId
                });

                throw;
            }
        }

        public async Task<bool> ResetLoginAttempts(string userId)
        {
            try
            {
                return await _uow.Repository<Staff>().ResetLoginAttempts(userId);
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "GetStaffAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = userId
                });

                throw;
            }
        }
        #endregion
    }
}
