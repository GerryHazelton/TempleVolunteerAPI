using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        IQueryable<Category> GetAllCategories(int propertyId, string userId);
        IQueryable<Category> GetCategoryByMatch(Expression<Func<Category, bool>> match, int propertyId, string userId);
        IQueryable<Category> GetCategoryWithDetails(Expression<Func<Category, bool>> match, int propertyId, string userId, WithDetails details);
        Category CreateCategory(Category category, int propertyId, string userId);
        bool UpdateCategory(Category category, int propertyId, string userId);
        bool DeleteCategory(Category category, int propertyId, string userId);
    }
}

