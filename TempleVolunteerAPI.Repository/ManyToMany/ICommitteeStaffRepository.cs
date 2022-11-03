using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface ICommitteeStaffRepository : IRepositoryManyToManyBase<CommitteeStaff>
    {
        IQueryable<CommitteeStaff> GetAllCommitteeStaff(int propertyId, string userId);
        IQueryable<CommitteeStaff> GetCommitteeStaffByMatch(Expression<Func<CommitteeStaff, bool>> match, int propertyId, string userId);
        IQueryable<CommitteeStaff> GetCommitteeStaffWithDetails(Expression<Func<CommitteeStaff, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreateCommitteeStaff(CommitteeStaff committeeStaff, int propertyId, string userId);
        bool UpdateCommitteeStaff(CommitteeStaff committeeStaff, int propertyId, string userId);
        bool DeleteCommitteeStaff(CommitteeStaff committeeStaff, int propertyId, string userId);
    }
}

