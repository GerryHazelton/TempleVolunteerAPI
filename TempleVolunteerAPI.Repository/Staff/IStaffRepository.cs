using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;

namespace TempleVolunteerAPI.Repository
{
    public interface IStaffRepository : IRepositoryBase<Staff>
    {
        Task<RepositoryResponse<Staff>> CustomSqlProcessAsync(Staff request);
        Task<RepositoryResponse<MyProfileRequest>> CustomMyProfileUpdateAsync(MyProfileRequest request);
    }
}

