using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using System.Text;
using System.Linq.Expressions;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventService : IEventService
    {
        private readonly IRepositoryWrapper _uow;

        public EventService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(Event entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Event entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Event> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Event> FindByCondition(Expression<Func<Event, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(Event entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}