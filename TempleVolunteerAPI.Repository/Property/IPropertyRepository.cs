using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IPropertyRepository : IRepositoryBase<Property>
    {
        IQueryable<Property> GetAllProperties(int propertyId, string userId);
        IQueryable<Property> GetPropertyByMatch(Expression<Func<Property, bool>> match, int propertyId, string userId);
        IQueryable<Property> GetPropertyWithDetails(Expression<Func<Property, bool>> match, int propertyId, string userId, WithDetails details);
        Property CreateProperty(Property property, int propertyId, string userId);
        bool UpdateProperty(Property property, int propertyId, string userId);
        bool DeleteProperty(Property property, int propertyId, string userId);
    }
}

