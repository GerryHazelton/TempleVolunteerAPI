using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Repository
{
    public class RoleStaffRepository : RepositoryManyToManyBase<RoleStaff>, IRoleStaffRepository
    {
        public RoleStaffRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}

