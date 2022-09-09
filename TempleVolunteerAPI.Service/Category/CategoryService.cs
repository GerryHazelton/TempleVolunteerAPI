using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}