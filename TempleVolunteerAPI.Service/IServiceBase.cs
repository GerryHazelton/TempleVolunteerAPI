using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IServiceBase<T>
    {
        Task<IList<T>> GetAllAsync(int propertyId, string createdBy);
        Task<T> GetByIdAsync(int Id, int propertyId, string createdBy);
        Task<T> AddAsync(T entity, int propertyId, string createdBy);
        Task<T> UpdateAsync(T entity, int propertyId, string createdBy);
        Task<T> DeleteAsync(int id, int propertyId, string createdBy);
        Task ErrorLog(ErrorRequest error);
    }
}
