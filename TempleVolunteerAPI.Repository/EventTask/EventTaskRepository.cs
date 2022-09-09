using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class EventTaskRepository : RepositoryBase<EventTask>, IEventTaskRepository
    {
        public EventTaskRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
