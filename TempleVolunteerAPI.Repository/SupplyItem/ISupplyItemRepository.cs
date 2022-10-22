using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface ISupplyItemRepository : IRepositoryBase<SupplyItem>
    {
        IQueryable<SupplyItem> GetAllSupplyItems(int propertyId, string userId);
        IQueryable<SupplyItem> GetSupplyItemByMatch(Expression<Func<SupplyItem, bool>> match, int propertyId, string userId);
        bool CreateSupplyItem(SupplyItem supplyItem, int propertyId, string userId);
        bool UpdateSupplyItem(SupplyItem supplyItem, int propertyId, string userId);
        bool DeleteSupplyItem(SupplyItem supplyItem, int propertyId, string userId);
    }
}

