using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IMessageService
    {
        Task<bool> AddAsync(Message message);
        Task<IList<Message>> GetAllAsync();
        Task<List<Message>> GetAllByIdAsync(string userId);
    }
}
