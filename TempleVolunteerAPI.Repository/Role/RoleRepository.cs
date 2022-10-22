using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync(int propertyId, string userId)
        {
            return await FindAll(propertyId, userId)
               .OrderBy(x => x.Name)
               .ToListAsync();
        }

        public async Task<Role> GetRoleByMatchAsync(Expression<Func<Role, bool>> match, int propertyId, string userId)
        {
            return await FindByCondition(match, propertyId, userId).FirstOrDefaultAsync();
        }

        public async Task<Role> GetRoleWithDetailsAsync(Expression<Func<Role, bool>> match, int propertyId, string userId)
        {
            return await FindByCondition(match, propertyId, userId).FirstOrDefaultAsync();
        }

        public bool CreateRole(Role role, int propertyId, string userId)
        {
            return Create(role, propertyId, userId);
        }

        public bool UpdateRole(Role role, int propertyId, string userId)
        {
            return Update(role, propertyId, userId);
        }

        public bool DeleteRole(Role role, int propertyId, string userId)
        {
            return Delete(role, propertyId, userId);
        }
    }
}
