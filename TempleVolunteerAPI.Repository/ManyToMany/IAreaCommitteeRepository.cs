using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IAreaCommitteeRepository : IRepositoryManyToManyBase<AreaCommittee>
    {
        IQueryable<AreaCommittee> GetAllAreaCommittees(int propertyId, string userId);
        IQueryable<AreaCommittee> GetAreaCommitteeByMatch(Expression<Func<AreaCommittee, bool>> match, int propertyId, string userId);
        IQueryable<AreaCommittee> GetAreaCommitteeWithDetails(Expression<Func<AreaCommittee, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreateAreaCommittee(AreaCommittee areaCommittee, int propertyId, string userId);
        bool UpdateAreaCommittee(AreaCommittee areaCommittee, int propertyId, string userId);
        bool DeleteAreaCommittee(AreaCommittee areaCommittee, int propertyId, string userId);
    }
}

