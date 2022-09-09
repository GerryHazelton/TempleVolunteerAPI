using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
