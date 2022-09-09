using Microsoft.Extensions.Options;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using System.Net.Mail;
using System.Text;

namespace TempleVolunteerAPI.Service
{
    public class EmailService : IEmailService
    {
        private readonly AppSettings _appSettings;
        private readonly IErrorLogService _errorLogService;
        private string _uri;

        public EmailService(IOptions<AppSettings> appSettings, IErrorLogService errorLogService)
        {
            _appSettings = appSettings.Value;
            _errorLogService = errorLogService;

            _uri = _appSettings.UriLocal;
            //_uri = _appSettings.UriHiranyaloka;
            //_uri = _appSettings.UriProduction;
        }

        public async Task<bool> Send(string toEmail, string subject, string body, string fromEmail = null)
        {
            try
            {
                MailMessage emailMessage = new MailMessage();
                emailMessage.From = new MailAddress(fromEmail);
                emailMessage.To.Add(new MailAddress(toEmail));
                emailMessage.Subject = subject;
                emailMessage.IsBodyHtml = true;
                emailMessage.Body = body;
                emailMessage.Priority = MailPriority.Normal;

                using (SmtpClient MailClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    MailClient.EnableSsl = true;
                    MailClient.Credentials = new System.Net.NetworkCredential("srfsdp@gmail.com", "M&st$R1952!");
                    MailClient.Send(emailMessage);
                }
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "EmailService: Send",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    CreatedBy = fromEmail
                });

                return false;
            }

            return true;
        }

        public async Task<bool> SendVerificationEmail(Staff model)
        {
            try
            {
                StringBuilder message = new StringBuilder("<h4>Registration Email</h4>");
                message.AppendFormat("Greetings {0} - your temporary password is: <b>Master1952SRF!</b>. Please change your password once you have logged in.", model.FirstName);
                message.Append("<p></p>");
                message.Append("Please click the link below to complete your registration:");
                message.AppendFormat("<a href={0}/Account/VerifyEmailAddress?emailAddress={1}> Complete Registration </a>", _uri, model.EmailAddress);

                await Send(model.EmailAddress, subject: "Summer Day Program - Verify Registration Email", message.ToString(), _appSettings.EmailFrom);
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "SendVerificationEmail",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = model.EmailAddress
                });

                throw new AppException("Unable to send verification email (Service: SendVerificationEmail)");
            }

            return true;
        }

        public async Task<string> SendAlreadyRegisteredEmail(string emailAddress)
        {
            try
            {
                StringBuilder message = new StringBuilder("<h4>Email Already Registered</h4>");
                message.AppendFormat("If you don't know your password please click:");
                message.AppendFormat("<a href={0}/Account/ForgotPassword?emailAddress={1}> Forgot Password</a>", _uri, emailAddress);

                await Send(emailAddress, "Summer Day Program - Already Registered", message.ToString(), _appSettings.EmailFrom);

                return "Summer Day Program - Email Already Registered";
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "SendAlreadyRegisteredEmail",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = emailAddress
                });

                throw new AppException("Unable to send already registered email (Service: SendAlreadyRegisteredEmail)");
            }
        }

        public async Task<bool> SendPasswordResetEmail(Staff model)
        {
            try
            {
                StringBuilder message = new StringBuilder("<h4>Reset Password</h4>");
                message.AppendFormat("Greetings {0} - please click the below link to reset your password. This link will be valid for 3 days:", model.FirstName);
                message.AppendFormat("<a href={0}/Account/ResetPassword?emailAddress={1}&token={2}>Reset Password</a>", _uri, model.EmailAddress);

                await Send (model.EmailAddress, "Summer Day Program - Reset Password", message.ToString(), _appSettings.EmailFrom);
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "SendPasswordResetEmail",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = 0,
                    CreatedBy = model.EmailAddress
                });
            }

            return true;
        }
    }
}
