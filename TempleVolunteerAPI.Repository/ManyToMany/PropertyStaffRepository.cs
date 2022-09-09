using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace SRFSDP.Api.Repository
{
    public class PropertyStaffRepository : RepositoryManyToManyBase<PropertyStaff>, IPropertyStaffRepository
    {
        public PropertyStaffRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}

