using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class PropertyStaffService : ServiceManyToManyBase<PropertyStaff>, IPropertyStaffService
    {
        public PropertyStaffService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}