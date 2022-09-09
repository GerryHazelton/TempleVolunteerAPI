using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public interface IStaffRepository : IRepositoryBase<Staff>
    {
        public Task<Staff> CustomUpdateAsync(Staff updated);
    }
}

