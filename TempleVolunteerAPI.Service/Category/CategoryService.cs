using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryWrapper _uow;

        public CategoryService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(Category entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> FindByCondition(Expression<Func<Category, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}