using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
