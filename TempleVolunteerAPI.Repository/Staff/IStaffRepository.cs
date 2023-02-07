using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IStaffRepository : IRepositoryBase<Staff>
    {
        IQueryable<Staff> GetAllStaff(int staffId, string userId);
        IQueryable<Staff> GetStaffByMatch(Expression<Func<Staff, bool>> match, int propertyId, string userId);
        IQueryable<Staff> GetStaffWithDetails(Expression<Func<Staff, bool>> match, int propertyId, string userId, WithDetails details);
        Staff CreateStaff(Staff staff, int propertyId, string userId);
        bool UpdateStaff(Staff staff, int propertyId, string userId);
        bool DeleteStaff(Staff staff, int propertyId, string userId);
        void CustomMyProfileUpdate(MyProfileRequest request);
        void CustomStaffUpdate(Staff request, int[] credentialIds, int[] roleIds);
        void RecordLoginAttempts(string userId, int propertyId);
        void ResetLoginAttempts(string userId, int propertyId);
    }
}

