using System.Linq.Expressions;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class PropertyStaffService : IPropertyStaffService
    {
        public PropertyStaffService(IRepositoryWrapperManyToMany uow)
        {

        }

        public bool Create(PropertyStaff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PropertyStaff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PropertyStaff> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PropertyStaff> FindByCondition(Expression<Func<PropertyStaff, bool>> expression, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PropertyStaff> FindByCondition(Expression<Func<PropertyStaff, bool>> match, int propertyId, string userId, EnumHelper.WithDetails details)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PropertyStaff> FindByConditionAsync(Expression<Func<PropertyStaff, bool>> match, int propertyId, string userId, EnumHelper.WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(PropertyStaff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}