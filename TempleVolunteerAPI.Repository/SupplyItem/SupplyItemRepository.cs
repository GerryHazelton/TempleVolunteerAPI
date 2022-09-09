using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class SupplyItemRepository : RepositoryBase<SupplyItem>, ISupplyItemRepository
    {
        public SupplyItemRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
