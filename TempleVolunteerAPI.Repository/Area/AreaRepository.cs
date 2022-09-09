using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class AreaRepository : RepositoryBase<Area>, IAreaRepository
    {
        public AreaRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
