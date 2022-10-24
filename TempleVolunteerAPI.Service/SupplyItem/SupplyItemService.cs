using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class SupplyItemService : ISupplyItemService
    {
        private readonly IRepositoryWrapper _uow;

        public SupplyItemService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public SupplyItem Create(SupplyItem entity, int propertyId, string userId)
        {
            return _uow.SupplyItems.CreateSupplyItem(entity, propertyId, userId);
        }

        public bool Delete(SupplyItem entity, int propertyId, string userId)
        {
            return _uow.SupplyItems.DeleteSupplyItem(entity, propertyId, userId);
        }

        public IQueryable<SupplyItem> FindAll(int propertyId, string userId)
        {
            return _uow.SupplyItems.GetAllSupplyItems(propertyId, userId);
        }

        public IQueryable<SupplyItem> FindByCondition(Expression<Func<SupplyItem, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.SupplyItems.GetSupplyItemByMatch(match, propertyId, userId);
        }

        public bool Update(SupplyItem entity, int propertyId, string userId)
        {
            return _uow.SupplyItems.UpdateSupplyItem(entity, propertyId, userId);
        }
    }
}