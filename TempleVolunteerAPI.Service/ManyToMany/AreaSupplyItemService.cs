using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class AreaSupplyItemService : IAreaSupplyItemService
    {
        private readonly IRepositoryWrapper _uow;

        public AreaSupplyItemService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(AreaSupplyItem entity, int propertyId, string userId)
        {
            return _uow.AreasSupplyItems.CreateAreaSupplyItem(entity, propertyId, userId);
        }

        public bool Delete(AreaSupplyItem entity, int propertyId, string userId)
        {
            return _uow.AreasSupplyItems.DeleteAreaSupplyItem(entity, propertyId, userId);
        }

        public async Task<IQueryable<AreaSupplyItem>> FindAllAsync(int propertyId, string userId)
        {
            return (IQueryable<AreaSupplyItem>)_uow.AreasSupplyItems.GetAllAreasSupplyItemsAsync(propertyId, userId);
        }

        public async Task<IQueryable<AreaSupplyItem>> FindByConditionAsync(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return (IQueryable<AreaSupplyItem>)await _uow.AreasSupplyItems.GetAreaSupplyItemWithDetailsAsync(match, propertyId, userId, details);
        }

        public bool Update(AreaSupplyItem entity, int propertyId, string userId)
        {
            return _uow.AreasSupplyItems.UpdateAreaSupplyItem(entity, propertyId, userId);
        }
    }
}