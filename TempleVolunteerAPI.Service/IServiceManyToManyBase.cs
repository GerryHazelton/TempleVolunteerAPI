using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IServiceManyToManyBase<T>
    {
        Task<T> AddAsync(T entity, int propertyId, string createdBy);
        Task<T> UpdateAsync(T entity, int propertyId, string createdBy);
        Task<T> GetByIdByIdAsync(T entity, int propertyId, string createdBy);
        Task<bool> DeleteByIdByIdAsync(T entity, int propertyId, string createdBy);
        Task ErrorLog(ErrorRequest error);
    }
}
