using System.Linq.Expressions;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class StaffCredentialService : IStaffCredentialService
    {
        public StaffCredentialService(IRepositoryWrapperManyToMany uow)
        {

        }

        public bool Create(StaffCredential entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(StaffCredential entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffCredential> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffCredential> FindByCondition(Expression<Func<StaffCredential, bool>> expression, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffCredential> FindByCondition(Expression<Func<StaffCredential, bool>> match, int propertyId, string userId, EnumHelper.WithDetails details)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StaffCredential> FindByConditionAsync(Expression<Func<StaffCredential, bool>> match, int propertyId, string userId, EnumHelper.WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(StaffCredential entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}