using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class CommitteeStaffService : ICommitteeStaffService
    {
        private readonly IRepositoryWrapper _uow;

        public CommitteeStaffService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(CommitteeStaff entity, int propertyId, string userId)
        {
            return _uow.CommitteeStaff.CreateCommitteeStaff(entity, propertyId, userId);
        }

        public bool Delete(CommitteeStaff entity, int propertyId, string userId)
        {
            return _uow.CommitteeStaff.DeleteCommitteeStaff(entity, propertyId, userId);
        }

        public IQueryable<CommitteeStaff> FindAll(int propertyId, string userId)
        {
            return (IQueryable<CommitteeStaff>)_uow.CommitteeStaff.GetAllCommitteeStaff(propertyId, userId);
        }

        public IQueryable<CommitteeStaff> FindByCondition(Expression<Func<CommitteeStaff, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return (IQueryable<CommitteeStaff>)_uow.CommitteeStaff.GetCommitteeStaffWithDetails(match, propertyId, userId, details);
        }

        public bool Update(CommitteeStaff entity, int propertyId, string userId)
        {
            return _uow.CommitteeStaff.UpdateCommitteeStaff(entity, propertyId, userId);
        }
    }
}