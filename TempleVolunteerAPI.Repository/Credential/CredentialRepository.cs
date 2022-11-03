using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class CredentialRepository : RepositoryBase<Credential>, ICredentialRepository
    {
        private readonly ApplicationDBContext _context;

        public CredentialRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Credential> GetAllCredentials(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
        }

        public IQueryable<Credential> GetCredentialByMatch(Expression<Func<Credential, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<Credential> GetCredentialWithDetails(Expression<Func<Credential, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public Credential CreateCredential(Credential credential, int propertyId, string userId)
        {
            return Create(credential, propertyId, userId);
        }

        public bool UpdateCredential(Credential credential, int propertyId, string userId)
        {
            return Update(credential, propertyId, userId);
        }

        public bool DeleteCredential(Credential credential, int propertyId, string userId)
        {
            return Delete(credential, propertyId, userId);
        }
    }
}
