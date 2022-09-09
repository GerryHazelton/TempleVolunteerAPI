using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
