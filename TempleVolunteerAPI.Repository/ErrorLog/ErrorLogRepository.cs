using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class ErrorLogRepository : RepositoryBase<ErrorLog>, IErrorLogRepository
    {
        public ErrorLogRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
