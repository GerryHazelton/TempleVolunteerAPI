using System.Linq.Expressions;
using TempleVolunteerAPI.Domain.DTO;

namespace TempleVolunteerAPI.Repository
{
    public interface IRepositoryManyToManyBase<T> where T : class
    {
        Task<RepositoryResponse<T>> GetAllAsync();
        Task<RepositoryResponse<T>> GetByIdAsync(int id);
        Task<RepositoryResponse<T>> FindAsync(Expression<Func<T, bool>> match);
        Task<RepositoryResponse<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<RepositoryResponse<T>> AddAsync(T entity);
        Task<RepositoryResponse<T>> UpdateAsync(T entity);
        Task<RepositoryResponse<T>> DeleteAsync(T entity);
        Task<RepositoryResponse<T>> CountAync();
        Task<RepositoryResponse<T>> Filter(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            int? page = null,
            int? pageSize = null);
    }
}
