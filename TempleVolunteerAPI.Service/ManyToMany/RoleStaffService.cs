using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class RoleStaffService : ServiceManyToManyBase<RoleStaff>, IRoleStaffService
    {
        public RoleStaffService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}