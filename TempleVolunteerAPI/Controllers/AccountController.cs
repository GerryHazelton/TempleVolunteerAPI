
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.API
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IEmailService _emailService;
        private readonly IMessageService _messageService;
        private readonly IStaffService _staffService;
        private readonly IGeneralService _generalService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IPropertyService _propertyService;
        private ServiceResponse<IList<Property>> _collResponse;

        public AccountController(IAccountService accountService, 
            IEmailService emailService, 
            IStaffService staffService,
            IGeneralService generalService,
            IConfiguration config, 
            IMapper mapper, 
            IMessageService messageHistory,
            ITokenService tokenService,
            IPropertyService propertyService)
        {
            _accountService = accountService;
            _emailService = emailService;
            _staffService = staffService;
            _generalService = generalService;
            _config = config;
            _mapper = mapper;
            _messageService = messageHistory;
            _tokenService = tokenService;
            _propertyService = propertyService;
            _collResponse = new ServiceResponse<IList<Property>>();
        }

        [HttpPost("RegisterAsync")]
        public async Task<RegisterResponse> RegisterAsync([FromBody] RegisterRequest request)
        {
            Staff staff = _mapper.Map<Staff>(request);
            var general = _generalService.FindAll(request.PropertyId, request.EmailAddress);
            var gender = general.Where(x => x.Gender == request.Gender).FirstOrDefault();

            staff.StaffFileName = general.Where(x=>x.Gender == request.Gender).FirstOrDefault().Gender == "Male" ? "Male.png" : "Female.png";
            staff.StaffImage = general.Where(x => x.Gender == request.Gender).FirstOrDefault().MissingImage;
            staff.NewRegistration = true;

            RegisterResponse response = await _accountService.RegisterAsync(staff);

            return response;
        }

        [HttpPost("LoginAsync")]
        public async Task<TokenResponse> LoginAsync([FromBody] LoginRequest request)
        {
            TokenResponse response = await _accountService.LoginAsync(request);

            return response;
        }

        [HttpPut("MyProfileAsync")]
        public async Task<MyProfileResponse> MyProfileAsync([FromBody] MyProfileRequest request)
        {
            if (request.RemovePhoto)
            {
                var general = _generalService.FindAll(request.PropertyId, request.EmailAddress);
                var gender = general.Where(x => x.Gender == request.Gender).FirstOrDefault();

                request.StaffFileName = general.Where(x => x.Gender == request.Gender).FirstOrDefault().Gender == "Male" ? "Male.png" : "Female.png";
                request.StaffImage = general.Where(x => x.Gender == request.Gender).FirstOrDefault().MissingImage;
            }

            RepositoryResponse<MyProfileRequest> repositoryResponse = await _accountService.MyProfileAsync(request);
            MyProfileResponse response = new MyProfileResponse();

            if (repositoryResponse.Entity != null)
            {
                response.Staff = repositoryResponse.Entity;
                response.Success = true;
                response.Message = "Profile successfully updated.";
            }
            else
            {
                response.Error = repositoryResponse.Error;
                response.Success = false;
                response.Message = "Profile unable to be updated.";
            }

            return response;
        }

        [HttpPost("VerifyEmailAddressAsync")]
        public async Task<ServiceResponse<Staff>> VerifyEmailAddressAsync(VerifyEmailAddressRequest request)
        {
            ServiceResponse<Staff> response = await _accountService.VerifyEmailAddressAsync(request);

            return response;
        }

        [HttpPost("ForgotPasswordAsync")]
        public async Task<ServiceResponse<Staff>> ForgotPasswordAsync([FromBody] ForgotPasswordRequest request)
        {
            ServiceResponse<Staff> response = await _accountService.ForgotPasswordAsync(request);

            return response;
        }

        [HttpPost("ResetForgottenPasswordAsync")]
        public async Task<ServiceResponse<Staff>> ResetForgottenPasswordAsync([FromBody] ResetForgottenPasswordRequest request)
        {
            ServiceResponse<Staff> response = await _accountService.ResetForgotenPasswordAsync(request);

            return response;
        }

        [HttpPost("ResetPasswordAsync")]
        public async Task<ServiceResponse<Staff>> ResetPasswordAsync([FromBody] ResetPasswordRequest request)
        {
            ServiceResponse<Staff> response = await _accountService.ResetPasswordAsync(request);

            return response;
        }

        [HttpPost]
        [Route("refresh_token")]
        public async Task<IActionResult> RefreshToken(RefreshTokenRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.RefreshToken) || request.UserId == 0)
            {
                return BadRequest(new TokenResponse
                {
                    Message = "Missing refresh token details",
                    ErrorCode = "R01"
                });
            }

            var validateRefreshTokenResponse = await _tokenService.ValidateRefreshTokenAsync(request);

            if (!validateRefreshTokenResponse.Success)
            {
                return UnprocessableEntity(validateRefreshTokenResponse);
            }

            var tokenResponse = await _tokenService.GenerateTokensAsync(validateRefreshTokenResponse.UserId, validateRefreshTokenResponse.PropertyId);

            return Ok(new { AccessToken = tokenResponse.Item1, Refreshtoken = tokenResponse.Item2 });
        }

        [HttpPost("GetAllPropertiesAsync")]
        public async Task<ServiceResponse<IList<Property>>> GetAllPropertiesAsync([FromBody] MiscRequest request)
        {
            _collResponse.Data = _propertyService.FindAll(request.PropertyId, request.UserId).ToList();
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        #region Helpers
        private void SetTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(1)
            };

            Response.Cookies.Append("AccessToken", token, cookieOptions);
        }

        private string IPAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwarded-For"];
            }
            else
            {
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            }
        }
        #endregion
    }
}