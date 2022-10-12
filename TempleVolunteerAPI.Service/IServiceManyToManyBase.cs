using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;

namespace TempleVolunteerAPI.Service
{
    public interface IServiceManyToManyBase<T>
    {
        Task<IList<T>> GetAllAsync(int propertyId, string createdBy);
        Task<T> GetAsync(int Id, int propertyId, string createdBy);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> AddAsync(T entity, int propertyId, string createdBy);
        Task<T> UpdateAsync(T entity, int propertyId, string createdBy);
        Task<T> DeleteAsync(int id, int propertyId, string createdBy);
        Task ErrorLog(ErrorRequest error);
    }
}
