using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.API
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ErrorController : ControllerBase
    {
        private readonly IErrorLogService _errorLogService;

        public ErrorController(IErrorLogService errorLogService)
        {
            _errorLogService = errorLogService;
        }

        [HttpPost("LogErrorAsync")]
        public async Task<bool> LogErrorAsync(ErrorRequest error)
        {
            await this._errorLogService.LogError(error);

            return true;
        }
    }
}
