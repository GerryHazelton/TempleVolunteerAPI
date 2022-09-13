
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Service;

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
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IPropertyService _propertyService;
        private ServiceResponse<IList<Property>> _collResponse;

        public AccountController(IAccountService accountService, 
            IEmailService emailService, 
            IStaffService staffService, 
            IConfiguration config, 
            IMapper mapper, 
            IMessageService messageHistory,
            ITokenService tokenService,
            IPropertyService propertyService)
        {
            _accountService = accountService;
            _emailService = emailService;
            _staffService = staffService;
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
            RegisterResponse response = await _accountService.RegisterAsync(request);

            return response;
        }

        [HttpPost("LoginAsync")]
        public async Task<TokenResponse> LoginAsync([FromBody] LoginRequest request)
        {
            TokenResponse response = await _accountService.LoginAsync(request);

            return response;
        }

        [HttpPost("ForgotPasswordAsync")]
        public async Task<ServiceResponse<Staff>> ForgotPasswordAsync([FromBody] ForgotPasswordRequest request)
        {
            ServiceResponse<Staff> response = await _accountService.ForgotPasswordAsync(request);

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

            var tokenResponse = await _tokenService.GenerateTokensAsync(validateRefreshTokenResponse.UserId);

            return Ok(new { AccessToken = tokenResponse.Item1, Refreshtoken = tokenResponse.Item2 });
        }

        [HttpGet("GetAllPropertiesAsync")]
        public async Task<ServiceResponse<IList<Property>>> GetAllPropertiesAsync([FromBody] MiscRequest request)
        {
            _collResponse.Data = _mapper.Map<IList<Property>>(await _propertyService.GetAllAsync(request.PropertyId, request.UserId));
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