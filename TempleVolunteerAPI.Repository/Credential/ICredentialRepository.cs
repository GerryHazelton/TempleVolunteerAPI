using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface ICredentialRepository : IRepositoryBase<Credential>
    {
        IQueryable<Credential> GetAllCredentials(int propertyId, string userId);
        IQueryable<Credential> GetCredentialByMatch(Expression<Func<Credential, bool>> match, int propertyId, string userId);
        IQueryable<Credential> GetCredentialWithDetails(Expression<Func<Credential, bool>> match, int propertyId, string userId, WithDetails details);
        Credential CreateCredential(Credential credential, int propertyId, string userId);
        bool UpdateCredential(Credential credential, int propertyId, string userId);
        bool DeleteCredential(Credential credential, int propertyId, string userId);
    }
}

