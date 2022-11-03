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

        public Role Create(Role entity, int roleId, string userId)
        {
            var role = _uow.Roles.CreateRole(entity, roleId, userId);

            return role;
        }

        public bool Delete(Role entity, int roleId, string userId)
        {
            _result = _uow.Roles.DeleteRole(entity, roleId, userId);

            return _result;
        }

        public IQueryable<Role> FindAll(int roleId, string userId)
        {
            return _uow.Roles.GetAllRoles(roleId, userId);
        }

        public IQueryable<Role> FindByCondition(Expression<Func<Role, bool>> match, int roleId, string userId, WithDetails details)
        {
            return _uow.Roles.GetRoleWithDetails(match, roleId, userId, details);
        }

        public bool Update(Role entity, int roleId, string userId)
        {
            _result = _uow.Roles.UpdateRole(entity, roleId, userId);

            return _result;
        }
    }
}