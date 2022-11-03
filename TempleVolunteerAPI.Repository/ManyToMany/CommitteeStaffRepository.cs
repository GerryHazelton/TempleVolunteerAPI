using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class CommitteeStaffRepository : RepositoryManyToManyBase<CommitteeStaff>, ICommitteeStaffRepository
    {
        public CommitteeStaffRepository(ApplicationDBContext context)
            : base(context)
        {
        }
         
        public IQueryable<CommitteeStaff> GetAllCommitteeStaffs(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.CommitteeId).AsNoTracking();
        }

        public IQueryable<CommitteeStaff> GetCommitteeStaffByMatch(Expression<Func<CommitteeStaff, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<CommitteeStaff> GetCommitteeStaffWithDetails(Expression<Func<CommitteeStaff, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.Committee).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public bool CreateCommitteeStaff(CommitteeStaff committeeStaff, int propertyId, string userId)
        {
            return Create(committeeStaff, propertyId, userId);
        }

        public bool UpdateCommitteeStaff(CommitteeStaff committeeStaff, int propertyId, string userId)
        {
            return Update(committeeStaff, propertyId, userId);
        }

        public bool DeleteCommitteeStaff(CommitteeStaff committeeStaff, int propertyId, string userId)
        {
            return Delete(committeeStaff, propertyId, userId);
        }
    }
}

