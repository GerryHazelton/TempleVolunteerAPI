using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class CredentialService : ServiceBase<Credential>, ICredentialService
    {
        public CredentialService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}