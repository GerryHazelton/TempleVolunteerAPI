using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IEventRepository : IRepositoryBase<Event>
    {
        IQueryable<Event> GetAllEvents(int propertyId, string userId);
        IQueryable<Event> GetEventByMatch(Expression<Func<Event, bool>> match, int propertyId, string userId);
        IQueryable<Event> GetEventWithDetails(Expression<Func<Event, bool>> match, int propertyId, string userId, WithDetails details);
        Event CreateEvent(Event templeEvent, int propertyId, string userId);
        bool UpdateEvent(Event templeEvent, int propertyId, string userId);
        bool DeleteEvent(Event templeEvent, int propertyId, string userId);
    }
}

