using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Repository;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.Service
{
    public class StaffService : ServiceBase<Staff>, IStaffService
    {
        private readonly IUnitOfWork _uow;
        private readonly IEmailService _emailService;
        public StaffService(IUnitOfWork uow, IErrorLogService errorLog, IEmailService emailService) : base(uow, errorLog)
        {
            this._uow = uow;
            this._emailService = emailService;
        }

        public async Task<bool> CustomUpdateAsync(Staff entity, string userId)
        {
            return await _uow.Repository<Staff>().CustomSqlProcessAsync(entity, userId);
        }

        public override async Task<bool> AddAsync(Staff entity)
        {
            await _emailService.SendVerificationEmail(entity);

            return await base.AddAsync(entity);
        }
    }
}