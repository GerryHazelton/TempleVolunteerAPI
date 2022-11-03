using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IAreaEventTaskRepository : IRepositoryManyToManyBase<AreaEventTask>
    {
        IQueryable<AreaEventTask> GetAllAreaEventTasks(int propertyId, string userId);
        IQueryable<AreaEventTask> GetAreaEventTaskByMatch(Expression<Func<AreaEventTask, bool>> match, int propertyId, string userId);
        IQueryable<AreaEventTask> GetAreaEventTaskWithDetails(Expression<Func<AreaEventTask, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreateAreaEventTask(AreaEventTask areaEventTask, int propertyId, string userId);
        bool UpdateAreaEventTask(AreaEventTask areaEventTask, int propertyId, string userId);
        bool DeleteAreaEventTask(AreaEventTask areaEventTask, int propertyId, string userId);
    }
}

