using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class EventTaskService : ServiceBase<EventTask>, IEventTaskService
    {
        public EventTaskService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}