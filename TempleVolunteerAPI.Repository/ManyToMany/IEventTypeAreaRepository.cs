using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IEventTypeAreaRepository : IRepositoryManyToManyBase<EventTypeArea>
    {
        IQueryable<EventTypeArea> GetAllEventTypeAreas(int propertyId, string userId);
        IQueryable<EventTypeArea> GetEventTypeAreasByMatch(Expression<Func<EventTypeArea, bool>> match, int propertyId, string userId);
        IQueryable<EventTypeArea> GetEventTypeAreaWithDetails(Expression<Func<EventTypeArea, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreateEventTypeArea(EventTypeArea eventTypeArea, int propertyId, string userId);
        bool UpdateEventTypeArea(EventTypeArea eventTypeArea, int propertyId, string userId);
        bool DeleteEventTypeArea(EventTypeArea eventTypeArea, int propertyId, string userId);
    }
}

