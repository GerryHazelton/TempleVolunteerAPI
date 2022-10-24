using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class StaffCredentialRepository : RepositoryManyToManyBase<StaffCredential>, IStaffCredentialRepository
    {
        public StaffCredentialRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<StaffCredential> GetAllStaffCredentials(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.StaffId).AsNoTracking();
        }

        public IQueryable<StaffCredential> GetStaffCredentialsByMatch(Expression<Func<StaffCredential, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<StaffCredential> GetStaffCredentialWithDetails(Expression<Func<StaffCredential, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.AreaEventType:
                    return FindByCondition(match, propertyId, userId).Include(x => x.Credential).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public bool CreateStaffCredential(StaffCredential staffCredential, int propertyId, string userId)
        {
            return Create(staffCredential, propertyId, userId);
        }

        public bool UpdateStaffCredential(StaffCredential staffCredential, int propertyId, string userId)
        {
            return Update(staffCredential, propertyId, userId);
        }

        public bool DeleteStaffCredential(StaffCredential staffCredential, int propertyId, string userId)
        {
            return Delete(staffCredential, propertyId, userId);
        }
    }
}

