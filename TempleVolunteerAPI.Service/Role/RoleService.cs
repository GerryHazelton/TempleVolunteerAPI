using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRepositoryWrapper _uow;

        public RoleService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Role Create(Role entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Role entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Role> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Role> FindByCondition(Expression<Func<Role, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(Role entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}