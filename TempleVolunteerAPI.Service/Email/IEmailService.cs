using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Service
{
    public interface IEmailService
    {
        Task<bool> Send(string to, string subject, string html, string from = null);
        Task<bool> SendVerificationEmail(Staff model);
        Task<string> SendAlreadyRegisteredEmail(string emailAddress);
        Task<bool> SendPasswordResetEmail(Staff model);
    }
}
