using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace SRFSDP.Api.Repository
{
    public class RoleStaffRepository : RepositoryManyToManyBase<RoleStaff>, IRoleStaffRepository
    {
        public RoleStaffRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}

