using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using System.Text;

namespace TempleVolunteerAPI.Service
{
    public class EventService : ServiceBase<Event>, IEventService
    {
        public EventService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}