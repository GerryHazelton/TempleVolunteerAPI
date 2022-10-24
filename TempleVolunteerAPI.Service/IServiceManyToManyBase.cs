using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public interface IServiceManyToManyBase<T>
    {
        IQueryable<T> FindAll(int propertyId, string userId);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> match, int propertyId, string userId, WithDetails details);
        bool Create(T entity, int propertyId, string userId);
        bool Update(T entity, int propertyId, string userId);
        bool Delete(T entity, int propertyId, string userId);
    }
}
