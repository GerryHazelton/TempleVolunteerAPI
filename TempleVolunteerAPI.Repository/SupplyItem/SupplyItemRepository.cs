using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class SupplyItemRepository : RepositoryBase<SupplyItem>, ISupplyItemRepository
    {
        public SupplyItemRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<SupplyItem> GetAllSupplyItems(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name);
        }

        public IQueryable<SupplyItem> GetSupplyItemByMatch(Expression<Func<SupplyItem, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId);
        }

        public IQueryable<SupplyItem> GetSupplyItemWithDetails(Expression<Func<SupplyItem, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return FindByCondition(match, propertyId, userId);
        }

        public bool CreateSupplyItem(SupplyItem supplyItem, int propertyId, string userId)
        {
            return Create(supplyItem, propertyId, userId);
        }

        public bool UpdateSupplyItem(SupplyItem supplyItem, int propertyId, string userId)
        {
            return Update(supplyItem, propertyId, userId);
        }

        public bool DeleteSupplyItem(SupplyItem supplyItem, int propertyId, string userId)
        {
            return Delete(supplyItem, propertyId, userId);
        }
    }
}
