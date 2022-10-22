using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class PropertyService : IPropertyService
    {
        private readonly IRepositoryWrapper _uow;

        public PropertyService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(Property entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Property entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Property> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Property> FindByCondition(Expression<Func<Property, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(Property entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}