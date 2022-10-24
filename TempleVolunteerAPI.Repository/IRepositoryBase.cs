using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain.DTO;

namespace TempleVolunteerAPI.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> FindAll(int propertyId, string userId);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> match, int propertyId, string userId);
        T Create(T entity, int propertyId, string userId);
        bool Update(T entity, int propertyId, string userId);
        bool Delete(T entity, int propertyId, string userId);
    }
}
