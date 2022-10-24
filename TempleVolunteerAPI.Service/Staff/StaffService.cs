using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Repository;
using TempleVolunteerAPI.Service;
using TempleVolunteerAPI.Domain.DTO;
using System.Linq.Expressions;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class StaffService : IStaffService
    {
        private readonly IRepositoryWrapper _uow;
        private readonly IEmailService _emailService;
        RepositoryResponse<Staff> _repositoryResponse;
        private readonly IStaffRepository _staffRepository;

        public StaffService(IRepositoryWrapper uow, IEmailService emailService, IStaffRepository staffRepository)
        {
            this._uow = uow;
            this._emailService = emailService;
            _repositoryResponse = new RepositoryResponse<Staff>();
            _staffRepository = staffRepository;
        }

        public Task<bool> CustomUpdateAsync(Staff entity, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Staff> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Staff> FindByCondition(Expression<Func<Staff, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public Staff Create(Staff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Staff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Staff entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}