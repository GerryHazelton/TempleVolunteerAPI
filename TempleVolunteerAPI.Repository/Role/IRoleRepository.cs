using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public interface IRoleRepository : IRepositoryBase<Role>
    {
        Task<IEnumerable<Role>> GetAllRolesAsync(int propertyId, string userId);
        Task<Role> GetRoleByMatchAsync(Expression<Func<Role, bool>> match, int propertyId, string userId);
        Task<Role> GetRoleWithDetailsAsync(Expression<Func<Role, bool>> match, int propertyId, string userId);
        bool CreateRole(Role role, int propertyId, string userId);
        bool UpdateRole(Role role, int propertyId, string userId);
        bool DeleteRole(Role role, int propertyId, string userId);
    }
}

