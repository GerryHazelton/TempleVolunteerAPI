using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IPropertyStaffRepository : IRepositoryManyToManyBase<PropertyStaff>
    {
        IQueryable<PropertyStaff> GetAllPropertyStaff(int propertyId, string userId);
        IQueryable<PropertyStaff> GetPropertyStaffByMatch(Expression<Func<PropertyStaff, bool>> match, int propertyId, string userId);
        IQueryable<PropertyStaff> GetPropertyStaffWithDetails(Expression<Func<PropertyStaff, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreatePropertyStaff(PropertyStaff propertyStaff, int propertyId, string userId);
        bool UpdatePropertyStaff(PropertyStaff propertyStaff, int propertyId, string userId);
        bool DeletePropertyStaff(PropertyStaff propertyStaff, int propertyId, string userId);
    }
}

