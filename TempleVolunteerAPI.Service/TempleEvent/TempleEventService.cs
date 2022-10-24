using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventService : IEventService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public EventService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Event Create(Event entity, int propertyId, string userId)
        {
            var templeEvent = _uow.Events.CreateEvent(entity, propertyId, userId);

            return templeEvent;
        }

        public bool Delete(Event entity, int propertyId, string userId)
        {
            _result = _uow.Events.DeleteEvent(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Event> FindAll(int propertyId, string userId)
        {
            return _uow.Events.GetAllEvents(propertyId, userId);
        }

        public IQueryable<Event> FindByCondition(Expression<Func<Event, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Events.GetEventWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Event entity, int propertyId, string userId)
        {
            _result = _uow.Events.UpdateEvent(entity, propertyId, userId);

            return _result;
        }
    }
}