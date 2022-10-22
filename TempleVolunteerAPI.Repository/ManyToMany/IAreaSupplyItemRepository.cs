using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IAreaSupplyItemRepository : IRepositoryManyToManyBase<AreaSupplyItem>
    {
        Task<IEnumerable<AreaSupplyItem>> GetAllAreasSupplyItemsAsync(int propertyId, string userId);
        Task<AreaSupplyItem> GetAreaSupplyItemByMatchAsync(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId);
        Task<AreaSupplyItem> GetAreaSupplyItemWithDetailsAsync(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId, WithDetails details);
        bool CreateAreaSupplyItem(AreaSupplyItem areaSupplyItem, int propertyId, string userId);
        bool UpdateAreaSupplyItem(AreaSupplyItem areaSupplyItem, int propertyId, string userId);
        bool DeleteAreaSupplyItem(AreaSupplyItem areaSupplyItem, int propertyId, string userId);
    }
}

