using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public interface IGeneralService
    {
        IQueryable<General> FindByCondition(Expression<Func<General, bool>> match, int propertyId, string userId);
        ICollection<General> FindAll(int propertyId, string userId);
    }
}