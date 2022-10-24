using System;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IAreaRepository : IRepositoryBase<Area>
    {
        IQueryable<Area> GetAllAreas(int propertyId, string userId);
        IQueryable<Area> GetAreaByMatch(Expression<Func<Area, bool>> match, int propertyId, string userId);
        IQueryable<Area> GetAreaWithDetails(Expression<Func<Area, bool>> match, int propertyId, string userId, WithDetails details);
        Area CreateArea(Area area, int propertyId, string userId);
        bool UpdateArea(Area area, int propertyId, string userId);
        bool DeleteArea(Area area, int propertyId, string userId);
    }
}

