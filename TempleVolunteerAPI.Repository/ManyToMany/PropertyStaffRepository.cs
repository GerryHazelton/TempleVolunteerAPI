using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class PropertyStaffRepository : RepositoryManyToManyBase<PropertyStaff>, IPropertyStaffRepository
    {
        public PropertyStaffRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<PropertyStaff> GetAllPropertyStaff(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.StaffId).AsNoTracking();
        }

        public IQueryable<PropertyStaff> GetPropertyStaffByMatch(Expression<Func<PropertyStaff, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<PropertyStaff> GetPropertyStaffWithDetails(Expression<Func<PropertyStaff, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.AreaEventType:
                    return FindByCondition(match, propertyId, userId).Include(x => x.Staff).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public bool CreatePropertyStaff(PropertyStaff propertyStaff, int propertyId, string userId)
        {
            return Create(propertyStaff, propertyId, userId);
        }

        public bool UpdatePropertyStaff(PropertyStaff propertyStaff, int propertyId, string userId)
        {
            return Update(propertyStaff, propertyId, userId);
        }

        public bool DeletePropertyStaff(PropertyStaff propertyStaff, int propertyId, string userId)
        {
            return Delete(propertyStaff, propertyId, userId);
        }
    }
}

