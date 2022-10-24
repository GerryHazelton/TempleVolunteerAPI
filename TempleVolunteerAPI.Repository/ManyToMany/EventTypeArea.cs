using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class EventTypeAreaRepository : RepositoryManyToManyBase<EventTypeArea>, IEventTypeAreaRepository
    {
        public EventTypeAreaRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<EventTypeArea> GetAllEventTypeAreas(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.AreaId).AsNoTracking();
        }

        public IQueryable<EventTypeArea> GetEventTypeAreasByMatch(Expression<Func<EventTypeArea, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<EventTypeArea> GetEventTypeAreaWithDetails(Expression<Func<EventTypeArea, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.AreaEventType:
                    return FindByCondition(match, propertyId, userId).Include(x => x.Area).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public bool CreateEventTypeArea(EventTypeArea eventTypeArea, int propertyId, string userId)
        {
            return Create(eventTypeArea, propertyId, userId);
        }

        public bool UpdateEventTypeArea(EventTypeArea eventTypeArea, int propertyId, string userId)
        {
            return Update(eventTypeArea, propertyId, userId);
        }

        public bool DeleteEventTypeArea(EventTypeArea eventTypeArea, int propertyId, string userId)
        {
            return Delete(eventTypeArea, propertyId, userId);
        }
    }
}

