using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class AreaCommitteeRepository : RepositoryManyToManyBase<AreaCommittee>, IAreaCommitteeRepository
    {
        public AreaCommitteeRepository(ApplicationDBContext context)
            : base(context)
        {
        }
         
        public IQueryable<AreaCommittee> GetAllAreaCommittees(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.AreaId).AsNoTracking();
        }

        public IQueryable<AreaCommittee> GetAreaCommitteeByMatch(Expression<Func<AreaCommittee, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<AreaCommittee> GetAreaCommitteeWithDetails(Expression<Func<AreaCommittee, bool>> match, int propertyId, string userId, WithDetails details)
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

        public bool CreateAreaCommittee(AreaCommittee areaCommittee, int propertyId, string userId)
        {
            return Create(areaCommittee, propertyId, userId);
        }

        public bool UpdateAreaCommittee(AreaCommittee areaCommittee, int propertyId, string userId)
        {
            return Update(areaCommittee, propertyId, userId);
        }

        public bool DeleteAreaCommittee(AreaCommittee areaCommittee, int propertyId, string userId)
        {
            return Delete(areaCommittee, propertyId, userId);
        }
    }
}

