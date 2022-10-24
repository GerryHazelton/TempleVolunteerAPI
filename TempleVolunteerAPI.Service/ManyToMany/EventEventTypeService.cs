using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventEventTypeService : IEventEventTypeService
    {
        private readonly IRepositoryWrapper _uow;

        public EventEventTypeService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(EventEventType entity, int propertyId, string userId)
        {
            return _uow.EventEventTypes.CreateEventEventType(entity, propertyId, userId);
        }

        public bool Delete(EventEventType entity, int propertyId, string userId)
        {
            return _uow.EventEventTypes.DeleteEventEventType(entity, propertyId, userId);
        }

        public IQueryable<EventEventType> FindAll(int propertyId, string userId)
        {
            return (IQueryable<EventEventType>)_uow.EventEventTypes.GetAllEventEventTypes(propertyId, userId);
        }

        public IQueryable<EventEventType> FindByCondition(Expression<Func<EventEventType, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return (IQueryable<EventEventType>)_uow.EventEventTypes.GetEventEventTypeWithDetails(match, propertyId, userId, details);
        }

        public bool Update(EventEventType entity, int propertyId, string userId)
        {
            return _uow.EventEventTypes.UpdateEventEventType(entity, propertyId, userId);
        }
    }
}