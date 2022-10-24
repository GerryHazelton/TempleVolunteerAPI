using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventTypeAreaService : IEventTypeAreaService
    {
        private readonly IRepositoryWrapper _uow;

        public EventTypeAreaService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(EventTypeArea entity, int propertyId, string userId)
        {
            return _uow.EventTypeAreas.CreateEventTypeArea(entity, propertyId, userId);
        }

        public bool Delete(EventTypeArea entity, int propertyId, string userId)
        {
            return _uow.EventTypeAreas.DeleteEventTypeArea(entity, propertyId, userId);
        }

        public IQueryable<EventTypeArea> FindAll(int propertyId, string userId)
        {
            return (IQueryable<EventTypeArea>)_uow.EventTypeAreas.GetAllEventTypeAreas(propertyId, userId);
        }

        public IQueryable<EventTypeArea> FindByCondition(Expression<Func<EventTypeArea, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return (IQueryable<EventTypeArea>)_uow.EventTypeAreas.GetEventTypeAreaWithDetails(match, propertyId, userId, details);
        }

        public bool Update(EventTypeArea entity, int propertyId, string userId)
        {
            return _uow.EventTypeAreas.UpdateEventTypeArea(entity, propertyId, userId);
        }
    }
}