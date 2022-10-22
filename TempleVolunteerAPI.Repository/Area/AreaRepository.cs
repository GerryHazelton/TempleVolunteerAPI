using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class AreaRepository : RepositoryBase<Area>, IAreaRepository
    {
        public AreaRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<Area> GetAllAreas(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
        }
        
        public IQueryable<Area> GetAreaByMatch(Expression<Func<Area, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId);
        }
        
        public IQueryable<Area> GetAreaWithDetails(Expression<Func<Area, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.AreaEventTask:
                    return FindByCondition(match, propertyId, userId).Include(x=>x.EventTasks);
                    break;
                case WithDetails.AreaEventType:
                    return FindByCondition(match, propertyId, userId).Include(x => x.EventTypes);
                    break;
                case WithDetails.AreaSupplyItem:
                    return FindByCondition(match, propertyId, userId).Include(x => x.SupplyItems);
                    break;
                default:
                    return FindByCondition(match, propertyId, userId);
                    break;
           }
        }
        
        public bool CreateArea(Area area, int propertyId, string userId)
        {
            return Create(area, propertyId, userId);
        }
        
        public bool UpdateArea(Area area, int propertyId, string userId)
        {
            return Update(area, propertyId, userId);
        }
        
        public bool DeleteArea(Area area, int propertyId, string userId)
        {
            return Delete(area, propertyId, userId);
        }
    }
}
