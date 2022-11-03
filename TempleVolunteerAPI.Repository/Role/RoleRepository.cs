using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        private readonly ApplicationDBContext _context;

        public RoleRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Role> GetAllRoles(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
        }

        public IQueryable<Role> GetRoleByMatch(Expression<Func<Role, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<Role> GetRoleWithDetails(Expression<Func<Role, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public Role CreateRole(Role role, int propertyId, string userId)
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
