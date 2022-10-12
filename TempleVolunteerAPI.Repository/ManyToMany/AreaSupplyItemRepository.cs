using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace SRFSDP.Api.Repository
{
    public class AreaSupplyItemRepository : RepositoryManyToManyBase<AreaSupplyItem>, IAreaSupplyItemRepository
    {
        public AreaSupplyItemRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}

