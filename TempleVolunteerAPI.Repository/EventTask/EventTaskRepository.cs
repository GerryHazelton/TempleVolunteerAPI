using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class EventTaskRepository : RepositoryBase<EventTask>, IEventTaskRepository
    {
        private readonly ApplicationDBContext _context;

        public EventTaskRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<EventTask> GetAllEventTasks(int propertyId, string userId)
        {
            var eventTasks = FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
            return eventTasks.Where(x => x.PropertyId == propertyId);
        }

        public IQueryable<EventTask> GetEventTaskByMatch(Expression<Func<EventTask, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<EventTask> GetEventTaskWithDetails(Expression<Func<EventTask, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public EventTask CreateEventTask(EventTask eventTask, int propertyId, string userId)
        {
            return Create(eventTask, propertyId, userId);
        }

        public bool UpdateEventTask(EventTask eventTask, int propertyId, string userId)
        {
            return Update(eventTask, propertyId, userId);
        }

        public bool DeleteEventTask(EventTask eventTask, int propertyId, string userId)
        {
            return Delete(eventTask, propertyId, userId);
        }
    }
}
