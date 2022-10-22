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

        public async Task<IEnumerable<AreaSupplyItem>> GetAllAreasSupplyItemsAsync(int propertyId, string userId)
        {
            return await FindAll(propertyId, userId)
               .OrderBy(x => x.Area)
               .ToListAsync();
        }

        public async Task<AreaSupplyItem> GetAreaSupplyItemByMatchAsync(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId)
        {
            return await FindByCondition(match, propertyId, userId).FirstOrDefaultAsync();
        }

        public async Task<AreaSupplyItem> GetAreaSupplyItemWithDetailsAsync(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.AreaEventTask:
                    return await FindByCondition(match, propertyId, userId).Include(x => x.SupplyItem).FirstOrDefaultAsync();
                    break;
                case WithDetails.AreaEventType:
                    return await FindByCondition(match, propertyId, userId).Include(x => x.SupplyItem).FirstOrDefaultAsync();
                    break;
                case WithDetails.AreaSupplyItem:
                    return await FindByCondition(match, propertyId, userId).Include(x => x.SupplyItem).FirstOrDefaultAsync();
                    break;
                default:
                    return await FindByCondition(match, propertyId, userId).FirstOrDefaultAsync();
                    break;
            }
        }

        public bool CreateAreaSupplyItem(AreaSupplyItem area, int propertyId, string userId)
        {
            return Create(area, propertyId, userId);
        }

        public bool UpdateAreaSupplyItem(AreaSupplyItem area, int propertyId, string userId)
        {
            return Update(area, propertyId, userId);
        }

        public bool DeleteAreaSupplyItem(AreaSupplyItem area, int propertyId, string userId)
        {
            return Delete(area, propertyId, userId);
        }
    }
}

