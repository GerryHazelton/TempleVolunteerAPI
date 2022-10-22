using System.Linq.Expressions;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class RoleStaffService : IRoleStaffService
    {
        public RoleStaffService(IRepositoryWrapperManyToMany uow)
        {

        }

        public bool Create(RoleStaff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(RoleStaff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<RoleStaff> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<RoleStaff>> FindAllAsync(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<RoleStaff> FindByCondition(Expression<Func<RoleStaff, bool>> expression, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<RoleStaff>> FindByConditionAsync(Expression<Func<RoleStaff, bool>> match, int propertyId, string userId, EnumHelper.WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(RoleStaff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}