using Microsoft.Extensions.Logging;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class ErrorLogService : IErrorLogService
    {
        private readonly IUnitOfWork _uow;
        private readonly ILogger _logger;

        public ErrorLogService(IUnitOfWork uow, ILogger<EventService> logger)
        {
            _uow = uow;
            _logger = logger;
        }

        public async Task LogError(ErrorRequest error)
        {
            try
            {
                ErrorLog errorEntry = new ErrorLog(error.CreatedBy);
                errorEntry.FunctionName = error.FunctionName;
                errorEntry.ErrorMessage = error.ErrorMessage;
                errorEntry.StackTrace = error.StackTrace;
                errorEntry.Environment = error.Environment;
                errorEntry.PropertyId = error.PropertyId;
                errorEntry.CreatedBy = error.CreatedBy;
                errorEntry.CreatedDate = error.CreatedDate;

                await _uow.Repository<ErrorLog>().AddAsync(errorEntry);
            }
            catch(Exception ex2)
            {
                _logger?.LogCritical("There was an error on '{0}' exception: {1}", nameof(LogError), ex2);
            }
        }
    }
}
