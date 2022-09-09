using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IServiceBase<T>
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetAsync(int Id);
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
        Task ErrorLog(ErrorRequest error);
    }
}
