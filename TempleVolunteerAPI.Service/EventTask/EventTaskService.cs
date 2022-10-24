using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventTaskService : IEventTaskService
    {
        private readonly IRepositoryWrapper _uow;

        public EventTaskService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool IQueryable<EventTask>(EventTask entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(EventTask entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EventTask> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EventTask> FindByCondition(Expression<Func<EventTask, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(EventTask entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public EventTask Create(EventTask entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}