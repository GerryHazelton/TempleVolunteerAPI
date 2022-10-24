using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Repository
{
    public interface IStaffRoleRepository : IRepositoryManyToManyBase<StaffRole>
    {
    }
}

