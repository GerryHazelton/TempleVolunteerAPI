using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class AreaSupplyItemRepository : RepositoryManyToManyBase<AreaSupplyItem>, IAreaSupplyItemRepository
    {
        public AreaSupplyItemRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<AreaSupplyItem> GetAllAreaSupplyItems(int propertyId, string userId)
        {
            return FindAll(propertyId, userId)
               .OrderBy(x => x.AreaId).AsNoTracking();
        }

        public IQueryable<AreaSupplyItem> GetAreaSupplyItemByMatch(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<AreaSupplyItem> GetAreaSupplyItemWithDetails(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.SupplyItem).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public bool CreateAreaSupplyItem(AreaSupplyItem areaSupplyItem, int propertyId, string userId)
        {
            return Create(areaSupplyItem, propertyId, userId);
        }

        public bool UpdateAreaSupplyItem(AreaSupplyItem areaSupplyItem, int propertyId, string userId)
        {
            return Update(areaSupplyItem, propertyId, userId);
        }

        public bool DeleteAreaSupplyItem(AreaSupplyItem areaSupplyItem, int propertyId, string userId)
        {
            return Delete(areaSupplyItem, propertyId, userId);
        }
    }
}

