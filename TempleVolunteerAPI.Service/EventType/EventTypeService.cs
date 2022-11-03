using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventTypeService : IEventTypeService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public EventTypeService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public EventType Create(EventType entity, int propertyId, string userId)
        {
            var eventType = _uow.EventTypes.CreateEventType(entity, propertyId, userId);

            return eventType;
        }

        public bool Delete(EventType entity, int propertyId, string userId)
        {
            _result = _uow.EventTypes.DeleteEventType(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<EventType> FindAll(int propertyId, string userId)
        {
            return _uow.EventTypes.GetAllEventTypes(propertyId, userId);
        }

        public IQueryable<EventType> FindByCondition(Expression<Func<EventType, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.EventTypes.GetEventTypeWithDetails(match, propertyId, userId, details);
        }

        public bool Update(EventType entity, int propertyId, string userId)
        {
            _result = _uow.EventTypes.UpdateEventType(entity, propertyId, userId);

            return _result;
        }
    }
}