using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class AreaCommitteeService : IAreaCommitteeService
    {
        private readonly IRepositoryWrapper _uow;

        public AreaCommitteeService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(AreaCommittee entity, int propertyId, string userId)
        {
            return _uow.AreaCommittees.CreateAreaCommittee(entity, propertyId, userId);
        }

        public bool Delete(AreaCommittee entity, int propertyId, string userId)
        {
            return _uow.AreaCommittees.DeleteAreaCommittee(entity, propertyId, userId);
        }

        public IQueryable<AreaCommittee> FindAll(int propertyId, string userId)
        {
            return (IQueryable<AreaCommittee>)_uow.AreaCommittees.GetAllAreaCommittees(propertyId, userId);
        }

        public IQueryable<AreaCommittee> FindByCondition(Expression<Func<AreaCommittee, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return (IQueryable<AreaCommittee>)_uow.AreaCommittees.GetAreaCommitteeWithDetails(match, propertyId, userId, details);
        }

        public bool Update(AreaCommittee entity, int propertyId, string userId)
        {
            return _uow.AreaCommittees.UpdateAreaCommittee(entity, propertyId, userId);
        }
    }
}