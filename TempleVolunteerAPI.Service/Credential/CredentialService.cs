using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class CredentialService : ICredentialService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public CredentialService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Credential Create(Credential entity, int propertyId, string userId)
        {
            var credential = _uow.Credentials.CreateCredential(entity, propertyId, userId);

            return credential;
        }

        public bool Delete(Credential entity, int propertyId, string userId)
        {
            _result = _uow.Credentials.DeleteCredential(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Credential> FindAll(int propertyId, string userId)
        {
            return _uow.Credentials.GetAllCredentials(propertyId, userId);
        }

        public IQueryable<Credential> FindByCondition(Expression<Func<Credential, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Credentials.GetCredentialWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Credential entity, int propertyId, string userId)
        {
            _result = _uow.Credentials.UpdateCredential(entity, propertyId, userId);

            return _result;
        }
    }
}