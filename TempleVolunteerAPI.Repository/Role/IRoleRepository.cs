using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IRoleRepository : IRepositoryBase<Role>
    {
        IQueryable<Role> GetAllRoles(int roleId, string userId);
        IQueryable<Role> GetRoleByMatch(Expression<Func<Role, bool>> match, int roleId, string userId);
        IQueryable<Role> GetRoleWithDetails(Expression<Func<Role, bool>> match, int roleId, string userId, WithDetails details);
        Role CreateRole(Role role, int roleId, string userId);
        bool UpdateRole(Role role, int roleId, string userId);
        bool DeleteRole(Role role, int roleId, string userId);
    }
}

