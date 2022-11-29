using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class AreaRepository : RepositoryBase<Area>, IAreaRepository
    {
        private readonly ApplicationDBContext _context;

        public AreaRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Area> GetAllAreas(int propertyId, string userId)
        {
            var areas = FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
            return areas.Where(x => x.PropertyId == propertyId);
        }
        
        public IQueryable<Area> GetAreaByMatch(Expression<Func<Area, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }
        
        public IQueryable<Area> GetAreaWithDetails(Expression<Func<Area, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.SupplyItems).Include(x=>x.EventTasks).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
           }
        }
        
        public Area CreateArea(Area area, int propertyId, string userId)
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
