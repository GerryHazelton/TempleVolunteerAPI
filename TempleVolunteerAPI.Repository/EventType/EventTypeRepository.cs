using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class EventTypeRepository : RepositoryBase<EventType>, IEventTypeRepository
    {
        public EventTypeRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
