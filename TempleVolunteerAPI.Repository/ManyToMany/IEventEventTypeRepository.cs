using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IEventEventTypeRepository : IRepositoryManyToManyBase<EventEventType>
    {
        IQueryable<EventEventType> GetAllEventEventTypes(int propertyId, string userId);
        IQueryable<EventEventType> GetEventEventTypeByMatch(Expression<Func<EventEventType, bool>> match, int propertyId, string userId);
        IQueryable<EventEventType> GetEventEventTypeWithDetails(Expression<Func<EventEventType, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreateEventEventType(EventEventType areaSupplyItem, int propertyId, string userId);
        bool UpdateEventEventType(EventEventType areaSupplyItem, int propertyId, string userId);
        bool DeleteEventEventType(EventEventType areaSupplyItem, int propertyId, string userId);
    }
}

