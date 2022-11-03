using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class StaffService : IStaffService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public StaffService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Staff Create(Staff entity, int propertyId, string userId)
        {
            var staff = _uow.Staff.CreateStaff(entity, propertyId, userId);

            return staff;
        }

        public void CustomUpdate(MyProfileRequest entity, string userId)
        {
            _uow.Staff.CustomMyProfileUpdate(entity);
        }

        public bool Delete(Staff entity, int propertyId, string userId)
        {
            _result = _uow.Staff.DeleteStaff(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Staff> FindAll(int propertyId, string userId)
        {
            return _uow.Staff.GetAllStaff(propertyId, userId);
        }

        public IQueryable<Staff> FindByCondition(Expression<Func<Staff, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Staff.GetStaffWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Staff entity, int propertyId, string userId)
        {
            _result = _uow.Staff.UpdateStaff(entity, propertyId, userId);

            return _result;
        }
    }
}