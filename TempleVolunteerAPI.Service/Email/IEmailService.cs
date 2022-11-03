using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public interface IEmailService
    {
        Task<string> SendEmail(Staff request, EmailTypeEnum emailType);
        Task<bool> Send(string toEmail, string subject, string body, string fromEmail, int propertyId);
    }
}
