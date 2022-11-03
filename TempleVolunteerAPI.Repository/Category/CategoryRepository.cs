using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _context;

        public CategoryRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Category> GetAllCategories(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
        }

        public IQueryable<Category> GetCategoryByMatch(Expression<Func<Category, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<Category> GetCategoryWithDetails(Expression<Func<Category, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public Category CreateCategory(Category category, int propertyId, string userId)
        {
            return Create(category, propertyId, userId);
        }

        public bool UpdateCategory(Category category, int propertyId, string userId)
        {
            return Update(category, propertyId, userId);
        }

        public bool DeleteCategory(Category category, int propertyId, string userId)
        {
            return Delete(category, propertyId, userId);
        }
    }
}
