using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class CredentialRepository : RepositoryBase<Credential>, ICredentialRepository
    {
        public CredentialRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
