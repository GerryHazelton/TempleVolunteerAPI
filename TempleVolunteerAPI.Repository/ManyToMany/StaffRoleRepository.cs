using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Repository
{
    public class StaffRoleRepository : RepositoryManyToManyBase<StaffRole>, IStaffRoleRepository
    {
        public StaffRoleRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}

