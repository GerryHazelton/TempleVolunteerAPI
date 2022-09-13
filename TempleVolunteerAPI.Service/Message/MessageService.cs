using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class MessageService : IMessageService
    {
        private readonly IUnitOfWork _uow;
        private readonly IErrorLogService _errorLog;
        RepositoryResponse<Message> _repositoryResponse;

        public MessageService(IUnitOfWork uow, IErrorLogService errorLog)
        {
            _uow = uow;
            _errorLog = errorLog;
            _repositoryResponse = new RepositoryResponse<Message>();
        }

        public async Task<bool> AddAsync(Message message)
        {
            _repositoryResponse = await _uow.Repository<Message>().AddAsync(message);

            return _repositoryResponse.Result;
        }

        public async Task<IList<Message>> GetAllAsync()
        {
            _repositoryResponse = await _uow.Repository<Message>().GetAllAsync();

            return _repositoryResponse.Entities;
        }

        public async Task<List<Message>> GetAllByIdAsync(string userId)
        {
            _repositoryResponse = await _uow.Repository<Message>().GetAllAsync();

            return _repositoryResponse.Entities.Where(x => x.From == userId).ToList(); ;
        }
    }
}
