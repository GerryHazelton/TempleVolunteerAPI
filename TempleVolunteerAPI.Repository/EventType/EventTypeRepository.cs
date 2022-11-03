using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class EventTypeRepository : RepositoryBase<EventType>, IEventTypeRepository
    {
        private readonly ApplicationDBContext _context;

        public EventTypeRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<EventType> GetAllEventTypes(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
        }

        public IQueryable<EventType> GetEventTypeByMatch(Expression<Func<EventType, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<EventType> GetEventTypeWithDetails(Expression<Func<EventType, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.Areas).Include(x=>x.Events).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public EventType CreateEventType(EventType eventType, int propertyId, string userId)
        {
            return Create(eventType, propertyId, userId);
        }

        public bool UpdateEventType(EventType eventType, int propertyId, string userId)
        {
            return Update(eventType, propertyId, userId);
        }

        public bool DeleteEventType(EventType eventType, int propertyId, string userId)
        {
            return Delete(eventType, propertyId, userId);
        }
    }
}
