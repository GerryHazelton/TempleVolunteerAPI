using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IErrorLogService
    {
        public Task LogError(ErrorRequest error);
    }
}
