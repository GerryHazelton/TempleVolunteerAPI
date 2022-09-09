using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class SupplyItemService : ServiceBase<SupplyItem>, ISupplyItemService
    {
        public SupplyItemService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}