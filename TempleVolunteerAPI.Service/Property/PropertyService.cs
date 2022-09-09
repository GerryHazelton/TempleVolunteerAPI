using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class PropertyService : ServiceBase<Property>, IPropertyService
    {
        public PropertyService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {
        }
    }
}