using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventTypeService : IEventTypeService
    {
        private readonly IRepositoryWrapper _uow;

        public EventTypeService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(EventType entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(EventType entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EventType> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EventType> FindByCondition(Expression<Func<EventType, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(EventType entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}