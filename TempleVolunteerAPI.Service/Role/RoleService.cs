using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public RoleService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Role Create(Role entity, int propertyId, string userId)
        {
            var role = _uow.Roles.CreateRole(entity, propertyId, userId);

            return role;
        }

        public bool Delete(Role entity, int propertyId, string userId)
        {
            _result = _uow.Roles.DeleteRole(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Role> FindAll(int propertyId, string userId)
        {
            return _uow.Roles.GetAllRoles(propertyId, userId);
        }

        public IQueryable<Role> FindByCondition(Expression<Func<Role, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Roles.GetRoleWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Role entity, int propertyId, string userId)
        {
            _result = _uow.Roles.UpdateRole(entity, propertyId, userId);

            return _result;
        }
    }
}