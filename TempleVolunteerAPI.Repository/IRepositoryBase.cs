using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using System.Linq.Expressions;

namespace TempleVolunteerAPI.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<int> CountAync();

        IEnumerable<T> Filter(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            int? page = null,
            int? pageSize = null);

        Task<IList<T>> FindByAsync(Expression<Func<T, bool>> match);

        Task<bool> ExistAsync(Expression<Func<T, bool>> match);
        Task<bool> CustomSqlProcessAsync(T instance, string createdBy);
        Task<int> RecordLoginAttempts(string userId);
        Task<bool> ResetLoginAttempts(string userId);
        void LogError(LogErrorParms parms);
    }
}
