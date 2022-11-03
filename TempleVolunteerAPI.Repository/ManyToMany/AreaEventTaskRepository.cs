using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class AreaEventTaskRepository : RepositoryManyToManyBase<AreaEventTask>, IAreaEventTaskRepository
    {
        public AreaEventTaskRepository(ApplicationDBContext context)
            : base(context)
        {
        }
         
        public IQueryable<AreaEventTask> GetAllAreaEventTasks(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.AreaId).AsNoTracking();
        }

        public IQueryable<AreaEventTask> GetAreaEventTaskByMatch(Expression<Func<AreaEventTask, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<AreaEventTask> GetAreaEventTaskWithDetails(Expression<Func<AreaEventTask, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.EventTask).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public bool CreateAreaEventTask(AreaEventTask areaEventTask, int propertyId, string userId)
        {
            return Create(areaEventTask, propertyId, userId);
        }

        public bool UpdateAreaEventTask(AreaEventTask areaEventTask, int propertyId, string userId)
        {
            return Update(areaEventTask, propertyId, userId);
        }

        public bool DeleteAreaEventTask(AreaEventTask areaEventTask, int propertyId, string userId)
        {
            return Delete(areaEventTask, propertyId, userId);
        }
    }
}

