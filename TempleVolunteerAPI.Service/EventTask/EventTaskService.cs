using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EventTaskService : IEventTaskService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public EventTaskService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public EventTask Create(EventTask entity, int propertyId, string userId)
        {
            var eventTask = _uow.EventTasks.CreateEventTask(entity, propertyId, userId);

            return eventTask;
        }

        public bool Delete(EventTask entity, int propertyId, string userId)
        {
            _result = _uow.EventTasks.DeleteEventTask(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<EventTask> FindAll(int propertyId, string userId)
        {
            return _uow.EventTasks.GetAllEventTasks(propertyId, userId);
        }

        public IQueryable<EventTask> FindByCondition(Expression<Func<EventTask, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.EventTasks.GetEventTaskWithDetails(match, propertyId, userId, details);
        }

        public bool Update(EventTask entity, int propertyId, string userId)
        {
            _result = _uow.EventTasks.UpdateEventTask(entity, propertyId, userId);

            return _result;
        }
    }
}