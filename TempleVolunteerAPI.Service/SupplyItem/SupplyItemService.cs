using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class SupplyItemService : ServiceBase<SupplyItem>, ISupplyItemService
    {
        private RepositoryResponse<SupplyItem> _repositoryResponse;
        private readonly IUnitOfWork _uow;
        private IErrorLogService _errorLog;

        public SupplyItemService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {
            _repositoryResponse = new RepositoryResponse<SupplyItem>();
            _uow = uow;
            _errorLog = errorLog;
        }

       public override async Task<IList<SupplyItem>> GetAllAsync(int propertyId, string createdBy)
        {
            _repositoryResponse = await _uow.Repository<SupplyItem>().GetAllAsync();

            if (_repositoryResponse.Error != null)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: GetAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Entities.Where(x => x.PropertyId == propertyId).ToList();
        }
    }
}