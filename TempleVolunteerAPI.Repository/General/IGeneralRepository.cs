using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IGeneralRepository : IRepositoryBase<General>
    {
        IQueryable<General> GetByMatch(Expression<Func<General, bool>> match, int propertyId, string userId);
        ICollection<General> GetAll(int propertyId, string userId);
    }
}

