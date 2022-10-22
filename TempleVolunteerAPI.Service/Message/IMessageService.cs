using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IMessageService
    {
        Task<bool> AddAsync(Message message);
        Task<IList<Message>> GetAllAsync(int propertyId);
        Task<List<Message>> GetAllByIdAsync(int id);
    }
}
