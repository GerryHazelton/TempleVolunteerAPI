using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IEventTypeRepository : IRepositoryBase<EventType>
    {
        IQueryable<EventType> GetAllEventTypes(int propertyId, string userId);
        IQueryable<EventType> GetEventTypeByMatch(Expression<Func<EventType, bool>> match, int propertyId, string userId);
        IQueryable<EventType> GetEventTypeWithDetails(Expression<Func<EventType, bool>> match, int propertyId, string userId, WithDetails details);
        EventType CreateEventType(EventType eventType, int propertyId, string userId);
        bool UpdateEventType(EventType eventType, int propertyId, string userId);
        bool DeleteEventType(EventType eventType, int propertyId, string userId);
    }
}

