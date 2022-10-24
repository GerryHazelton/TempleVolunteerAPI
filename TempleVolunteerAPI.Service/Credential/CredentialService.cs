using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class CredentialService : ICredentialService
    {
        private readonly IRepositoryWrapper _uow;

        public CredentialService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Credential Create(Credential entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Credential entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Credential> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Credential> FindByCondition(Expression<Func<Credential, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(Credential entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}