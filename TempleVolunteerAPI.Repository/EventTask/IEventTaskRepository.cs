using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IEventTaskRepository : IRepositoryBase<EventTask>
    {
        IQueryable<EventTask> GetAllEventTasks(int propertyId, string userId);
        IQueryable<EventTask> GetEventTaskByMatch(Expression<Func<EventTask, bool>> match, int propertyId, string userId);
        IQueryable<EventTask> GetEventTaskWithDetails(Expression<Func<EventTask, bool>> match, int propertyId, string userId, WithDetails details);
        EventTask CreateEventTask(EventTask eventTask, int propertyId, string userId);
        bool UpdateEventTask(EventTask eventTask, int propertyId, string userId);
        bool DeleteEventTask(EventTask eventTask, int propertyId, string userId);
    }
}

