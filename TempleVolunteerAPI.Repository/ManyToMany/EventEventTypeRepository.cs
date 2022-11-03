using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class EventEventTypeRepository : RepositoryManyToManyBase<EventEventType>, IEventEventTypeRepository
    {
        public EventEventTypeRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<EventEventType> GetAllEventEventTypes(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.EventId).AsNoTracking();
        }

        public IQueryable<EventEventType> GetEventEventTypeByMatch(Expression<Func<EventEventType, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<EventEventType> GetEventEventTypeWithDetails(Expression<Func<EventEventType, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.EventType).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public bool CreateEventEventType(EventEventType area, int propertyId, string userId)
        {
            return Create(area, propertyId, userId);
        }

        public bool UpdateEventEventType(EventEventType area, int propertyId, string userId)
        {
            return Update(area, propertyId, userId);
        }

        public bool DeleteEventEventType(EventEventType area, int propertyId, string userId)
        {
            return Delete(area, propertyId, userId);
        }
    }
}

