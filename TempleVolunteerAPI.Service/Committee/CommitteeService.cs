using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class CommitteeService : ICommitteeService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public CommitteeService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Committee Create(Committee entity, int propertyId, string userId)
        {
            var committee = _uow.Committees.CreateCommittee(entity, propertyId, userId);

            return committee;
        }

        public bool Delete(Committee entity, int propertyId, string userId)
        {
            _result = _uow.Committees.DeleteCommittee(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Committee> FindAll(int propertyId, string userId)
        {
            return _uow.Committees.GetAllCommittees(propertyId, userId);
        }

        public IQueryable<Committee> FindByCondition(Expression<Func<Committee, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Committees.GetCommitteeWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Committee entity, int propertyId, string userId)
        {
            _result = _uow.Committees.UpdateCommittee(entity, propertyId, userId);

            return _result;
        }
    }
}