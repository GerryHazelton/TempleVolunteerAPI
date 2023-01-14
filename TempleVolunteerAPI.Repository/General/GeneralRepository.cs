using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class GeneralRepository : RepositoryBase<General>, IGeneralRepository
    {
        private readonly ApplicationDBContext _context;

        public GeneralRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<General> GetByMatch(Expression<Func<General, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public ICollection<General> GetAll(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).AsNoTracking().ToList();
        }
    }
}
