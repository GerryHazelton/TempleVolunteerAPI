using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;

namespace TempleVolunteerAPI.Repository
{
    public interface IStaffRepository : IRepositoryBase<Staff>
    {
        Task<RepositoryResponse<Staff>> CustomSqlProcessAsync(Staff request);
        Task<RepositoryResponse<MyProfileRequest>> CustomMyProfileUpdateAsync(MyProfileRequest request);

        Task<IEnumerable<Staff>> GetAllStaffAsync(int propertyId, string userId);
        Task<Staff> GetStaffByMatchAsync(Expression<Func<Staff, bool>> match, int propertyId, string userId);
        Task<Staff> GetStaffWithDetailsAsync(Expression<Func<Staff, bool>> match, int propertyId, string userId);
        Task RecordLoginAttempts(string userId, int propertyId);
        Task ResetLoginAttempts(string userId, int propertyId);
        bool CreateStaff(Staff staff, int propertyId, string userId);
        bool UpdateStaff(Staff staff, int propertyId, string userId);
        bool DeleteStaff(Staff staff, int propertyId, string userId);
    }
}

