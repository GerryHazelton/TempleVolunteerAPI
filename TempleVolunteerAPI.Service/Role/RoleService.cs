using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class RoleService : ServiceBase<Role>, IRoleService
    {
        public RoleService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {
        }
    }
}