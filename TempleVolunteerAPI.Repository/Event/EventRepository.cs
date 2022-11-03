using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        private readonly ApplicationDBContext _context;

        public EventRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Event> GetAllEvents(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
        }

        public IQueryable<Event> GetEventByMatch(Expression<Func<Event, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<Event> GetEventWithDetails(Expression<Func<Event, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.EventTypes).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public Event CreateEvent(Event templeEvent, int propertyId, string userId)
        {
            return Create(templeEvent, propertyId, userId);
        }

        public bool UpdateEvent(Event templeEvent, int propertyId, string userId)
        {
            return Update(templeEvent, propertyId, userId);
        }

        public bool DeleteEvent(Event templeEvent, int propertyId, string userId)
        {
            return Delete(templeEvent, propertyId, userId);
        }
    }
}
