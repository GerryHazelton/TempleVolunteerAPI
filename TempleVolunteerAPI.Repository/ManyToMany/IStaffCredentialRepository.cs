using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IStaffCredentialRepository : IRepositoryManyToManyBase<StaffCredential>
    {
        IQueryable<StaffCredential> GetAllStaffCredentials(int propertyId, string userId);
        IQueryable<StaffCredential> GetStaffCredentialsByMatch(Expression<Func<StaffCredential, bool>> match, int propertyId, string userId);
        IQueryable<StaffCredential> GetStaffCredentialWithDetails(Expression<Func<StaffCredential, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreateStaffCredential(StaffCredential staffCredential, int propertyId, string userId);
        bool UpdateStaffCredential(StaffCredential staffCredential, int propertyId, string userId);
        bool DeleteStaffCredential(StaffCredential staffCredential, int propertyId, string userId);
    }
}

