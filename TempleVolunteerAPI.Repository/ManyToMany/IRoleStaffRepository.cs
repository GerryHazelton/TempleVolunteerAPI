using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Repository
{
    public interface IRoleStaffRepository : IRepositoryManyToManyBase<RoleStaff>
    {
    }
}

