using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class PropertyRepository : RepositoryBase<Property>, IPropertyRepository
    {
        public PropertyRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
