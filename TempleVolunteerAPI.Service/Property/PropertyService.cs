using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class PropertyService : IPropertyService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public PropertyService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Property Create(Property entity, int propertyId, string userId)
        {
            var property = _uow.Properties.CreateProperty(entity, propertyId, userId);

            return property;
        }

        public bool Delete(Property entity, int propertyId, string userId)
        {
            _result = _uow.Properties.DeleteProperty(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Property> FindAll(int propertyId, string userId)
        {
            return _uow.Properties.GetAllProperties(propertyId, userId);
        }

        public IQueryable<Property> FindByCondition(Expression<Func<Property, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Properties.GetPropertyWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Property entity, int propertyId, string userId)
        {
            _result = _uow.Properties.UpdateProperty(entity, propertyId, userId);

            return _result;
        }
    }
}