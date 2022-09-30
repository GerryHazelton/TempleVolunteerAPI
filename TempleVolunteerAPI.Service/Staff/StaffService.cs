using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Repository;
using TempleVolunteerAPI.Service;
using TempleVolunteerAPI.Domain.DTO;

namespace TempleVolunteerAPI.Service
{
    public class StaffService : ServiceBase<Staff>, IStaffService
    {
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        RepositoryResponse<Staff> _repositoryResponse;
        private readonly IStaffRepository _staffRepository;


        public StaffService(IUnitOfWork uow, IErrorLogService errorLog, IEmailService emailService, IStaffRepository staffRepository) : base(uow, errorLog)
        {
            this._uow = uow;
            this._emailService = emailService;
            _repositoryResponse = new RepositoryResponse<Staff>();
            _staffRepository = staffRepository;
        }

        public async Task<bool> CustomUpdateAsync(Staff entity, string userId)
        {
            _repositoryResponse = await _staffRepository.CustomSqlProcessAsync(entity);

            return _repositoryResponse.Result;
        }
    }
}