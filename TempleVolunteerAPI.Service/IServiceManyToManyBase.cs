using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IServiceManyToManyBase<T>
    {
        Task<bool> AddAsync(T entity, string userId);
        Task<bool> UpdateAsync(T entity, string userId);
        Task<bool> GetByPropertyIdEventIdAsync(int propertyId, int EventId, string userId);
        Task<bool> DeleteAsync(int id, string userId);
        Task ErrorLog(ErrorRequest error);
    }
}
