using Microsoft.Extensions.Options;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using System.Net.Mail;
using System.Text;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class EmailService : IEmailService
    {
        private readonly AppSettings _appSettings;
        private readonly IErrorLogService _errorLogService;
        private string _uri;
        StringBuilder _message;

        public EmailService(IOptions<AppSettings> appSettings, IErrorLogService errorLogService)
        {
            _appSettings = appSettings.Value;
            _errorLogService = errorLogService;

            _uri = _appSettings.UriLocal;
            //_uri = _appSettings.UriHiranyaloka;
            //_uri = _appSettings.UriProduction;
        }

        public async Task<string> SendEmail(Staff request, int propertyId, EmailTypeEnum emailType)
        {
            try
            {
                switch (emailType)
                {
                    case EmailTypeEnum.EmailExists:
                    {
                            _message = new StringBuilder("<h4>Email Already Registered</h4>");
                            _message.AppendFormat("Hello {0} - if you don't know your password please click:", request.FirstName);
                            _message.AppendFormat("<a href={0}/Account/ForgotPassword?emailAddress={1}>Forgot Password</a>", _uri, request.EmailAddress);

                            await Send(request.EmailAddress, "Temple Volunteer - Already Registered", _message.ToString(), _appSettings.EmailFrom, propertyId);

                            return "Temple Volunteer - Email Already Registered";
                        }
                        break;

                    case EmailTypeEnum.RegisterEmail:
                        {
                            _message = new StringBuilder("<h4>Registration Email</h4>");
                            _message.AppendFormat("Hello {0} - your temporary password is: <b>Master1952SRF!</b>. Please change your password once you have logged in.", request.FirstName);
                            _message.Append("<p></p>");
                            _message.Append("Please click the link below to complete your registration:");
                            _message.AppendFormat("<a href={0}/Account/VerifyEmailAddress?emailAddress={1}> Complete Registration </a>", _uri, request.EmailAddress);
                        }
                        break;

                    case EmailTypeEnum.ResetPassword:
                        {
                            _message = new StringBuilder("<h4>Reset Password</h4>");
                            _message.AppendFormat("Hello {0} - please click the below link to reset your password. This link will be valid for 3 days:", request.FirstName);
                            _message.AppendFormat("<a href={0}/Account/ResetPassword?emailAddress={1}&token={2}>Reset Password</a>", _uri, request.EmailAddress);
                        }
                        break;

                    case EmailTypeEnum.ForgotPassword:
                        {
                            _message = new StringBuilder("<h4>Forgot Password</h4>");
                            _message.AppendFormat("Greetings {0} - please click the below link to reset your password. This link will be valid for 3 days:", request.FirstName);
                            _message.AppendFormat("<a href={0}/Account/ResetPassword?emailAddress={1}&token={2}>Reset Password</a>", _uri, request.EmailAddress);
                        }
                        break;
                }

                return "true";
            }
            catch (Exception ex)
            {
                await _errorLogService.LogError(new ErrorRequest
                {
                    FunctionName = "SendVerificationEmail",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = request.EmailAddress,
                    CreatedDate = DateTime.UtcNow
                });

                throw new AppException("Unable to send verification email (Service: SendVerificationEmail)");
            }
        }

        public async Task<bool> Send(string toEmail, string subject, string body, string fromEmail, int propertyId)
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
                    MailClient.Credentials = new System.Net.NetworkCredential("srfyssvolunteer@gmail.com", "Master1952!");
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
                    PropertyId = propertyId,
                    CreatedBy = fromEmail,
                    CreatedDate = DateTime.UtcNow
                });

                return false;
            }

            return true;
        }
    }
}
