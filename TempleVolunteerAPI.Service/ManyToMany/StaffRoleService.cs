using System.Linq.Expressions;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class StaffRoleService : IStaffRoleService
    {
        public StaffRoleService(IRepositoryWrapperManyToMany uow)
        {

        }

        public bool Create(StaffRole entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(StaffRole entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffRole> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffRole> FindByCondition(Expression<Func<StaffRole, bool>> expression, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffRole> FindByCondition(Expression<Func<StaffRole, bool>> match, int propertyId, string userId, EnumHelper.WithDetails details)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffRole> FindByConditionAsync(Expression<Func<StaffRole, bool>> match, int propertyId, string userId, EnumHelper.WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(StaffRole entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}