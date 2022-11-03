using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface ICommitteeRepository : IRepositoryBase<Committee>
    {
        IQueryable<Committee> GetAllCommittees(int propertyId, string userId);
        IQueryable<Committee> GetCommitteeByMatch(Expression<Func<Committee, bool>> match, int propertyId, string userId);
        IQueryable<Committee> GetCommitteeWithDetails(Expression<Func<Committee, bool>> match, int propertyId, string userId, WithDetails details);
        Committee CreateCommittee(Committee committee, int propertyId, string userId);
        bool UpdateCommittee(Committee committee, int propertyId, string userId);
        bool DeleteCommittee(Committee committee, int propertyId, string userId);
    }
}

