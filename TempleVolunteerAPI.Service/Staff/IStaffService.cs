using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.Service
{
    public interface IStaffService : IServiceBase<Staff>
    {
        void CustomUpdate(MyProfileRequest entity, string userId);
    }
}