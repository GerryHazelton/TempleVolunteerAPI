using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.Service
{
    public interface IStaffService : IServiceBase<Staff>
    {
        void CustomMyProfileUpdate(MyProfileRequest entity);
        void CustomStaffUpdate(Staff entity);
    }
}