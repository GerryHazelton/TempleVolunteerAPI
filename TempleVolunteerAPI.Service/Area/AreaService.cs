using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class AreaService : IAreaService
    {
        private readonly IRepositoryWrapper _uow;

        public AreaService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(Area entity, int propertyId, string userId)
        {
            _uow.Areas.CreateArea(entity, propertyId, userId);
            //_uow.Save();

            return true;
        }

        public bool Delete(Area entity, int propertyId, string userId)
        {
            return _uow.Areas.DeleteArea(entity, propertyId, userId);
        }

        public IQueryable<Area> FindAll(int propertyId, string userId)
        {
            return _uow.Areas.GetAllAreas(propertyId, userId);
        }

        public IQueryable<Area> FindByCondition(Expression<Func<Area, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Areas.GetAreaWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Area entity, int propertyId, string userId)
        {
            return _uow.Areas.UpdateArea(entity, propertyId, userId);
        }
    }
}