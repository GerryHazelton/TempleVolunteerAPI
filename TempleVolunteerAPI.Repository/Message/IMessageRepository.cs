using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public interface IMessageRepository
    {
        Task<bool> AddAsync(Message message);
        Task<IList<Message>> GetAllAsync();
        Task<IList<Message>> GetAllByIdAsync(int id);
    }
}
