using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public CategoryService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Category Create(Category entity, int propertyId, string userId)
        {
            var category = _uow.Categories.CreateCategory(entity, propertyId, userId);

            return category;
        }

        public bool Delete(Category entity, int propertyId, string userId)
        {
            _result = _uow.Categories.DeleteCategory(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Category> FindAll(int propertyId, string userId)
        {
            return _uow.Categories.GetAllCategories(propertyId, userId);
        }

        public IQueryable<Category> FindByCondition(Expression<Func<Category, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Categories.GetCategoryWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Category entity, int propertyId, string userId)
        {
            _result = _uow.Categories.UpdateCategory(entity, propertyId, userId);

            return _result;
        }
    }
}