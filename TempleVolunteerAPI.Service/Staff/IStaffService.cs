using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.Service
{
    public interface IStaffService : IServiceBase<Staff>
    {
        Task<bool> CustomUpdateAsync(Staff entity, string userId);
    }
}