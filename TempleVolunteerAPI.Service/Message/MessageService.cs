using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class MessageService : IMessageService
    {
        private readonly IRepositoryWrapper _uow;
        RepositoryResponse<Message> _repositoryResponse;

        public MessageService(IRepositoryWrapper uow)
        {
            _uow = uow;
            _repositoryResponse = new RepositoryResponse<Message>();
        }

        public async Task<bool> AddAsync(Message message)
        {
            await _uow.Messages.AddAsync(message);
            return true;
        }

        public async Task<IList<Message>> GetAllAsync(int propertyId)
        {
            _repositoryResponse.Entities = await _uow.Messages.GetAllAsync(propertyId);

            return _repositoryResponse.Entities;
        }

        public async Task<List<Message>> GetAllByIdAsync(int id)
        {
            _repositoryResponse.Entities = await _uow.Messages.GetAllByIdAsync(id);

            return _repositoryResponse.Entities.ToList();
        }
    }
}
