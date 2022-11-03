using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class AreaEventTaskService : IAreaEventTaskService
    {
        private readonly IRepositoryWrapper _uow;

        public AreaEventTaskService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(AreaEventTask entity, int propertyId, string userId)
        {
            return _uow.AreaEventTasks.CreateAreaEventTask(entity, propertyId, userId);
        }

        public bool Delete(AreaEventTask entity, int propertyId, string userId)
        {
            return _uow.AreaEventTasks.DeleteAreaEventTask(entity, propertyId, userId);
        }

        public IQueryable<AreaEventTask> FindAll(int propertyId, string userId)
        {
            return (IQueryable<AreaEventTask>)_uow.AreaEventTasks.GetAllAreaEventTasks(propertyId, userId);
        }

        public IQueryable<AreaEventTask> FindByCondition(Expression<Func<AreaEventTask, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return (IQueryable<AreaEventTask>)_uow.AreaEventTasks.GetAreaEventTaskWithDetails(match, propertyId, userId, details);
        }

        public bool Update(AreaEventTask entity, int propertyId, string userId)
        {
            return _uow.AreaEventTasks.UpdateAreaEventTask(entity, propertyId, userId);
        }
    }
}