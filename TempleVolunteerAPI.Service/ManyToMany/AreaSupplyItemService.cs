using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class AreaSupplyItemService : ServiceManyToManyBase<AreaSupplyItem>, IAreaSupplyItemService
    {
        public AreaSupplyItemService(IUnitOfWorkManyToMany uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}