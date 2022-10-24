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
            return _uow.AreaSupplyItems.CreateAreaSupplyItem(entity, propertyId, userId);
        }

        public bool Delete(AreaSupplyItem entity, int propertyId, string userId)
        {
            return _uow.AreaSupplyItems.DeleteAreaSupplyItem(entity, propertyId, userId);
        }

        public IQueryable<AreaSupplyItem> FindAll(int propertyId, string userId)
        {
            return (IQueryable<AreaSupplyItem>)_uow.AreaSupplyItems.GetAllAreaSupplyItems(propertyId, userId);
        }

        public IQueryable<AreaSupplyItem> FindByCondition(Expression<Func<AreaSupplyItem, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return (IQueryable<AreaSupplyItem>)_uow.AreaSupplyItems.GetAreaSupplyItemWithDetails(match, propertyId, userId, details);
        }

        public bool Update(AreaSupplyItem entity, int propertyId, string userId)
        {
            return _uow.AreaSupplyItems.UpdateAreaSupplyItem(entity, propertyId, userId);
        }
    }
}