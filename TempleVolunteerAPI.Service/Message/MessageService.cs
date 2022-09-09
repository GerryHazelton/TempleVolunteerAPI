using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class MessageService : IMessageService
    {
        private readonly IUnitOfWork _uow;
        private readonly IErrorLogService _errorLog;

        public MessageService(IUnitOfWork uow, IErrorLogService errorLog)
        {
            _uow = uow;
            _errorLog = errorLog;
        }

        public async Task<bool> AddAsync(Message message)
        {
            return await _uow.Repository<Message>().AddAsync(message);
        }

        public async Task<IList<Message>> GetAllAsync()
        {
            return await _uow.Repository<Message>().GetAllAsync();
        }

        public async Task<List<Message>> GetAllByIdAsync(string userId)
        {
            List<Message> messages = (List<Message>)await _uow.Repository<Message>().GetAllAsync();

            return messages.Where(x => x.From == userId).ToList();
        }
    }
}
