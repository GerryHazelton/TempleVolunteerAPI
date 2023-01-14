﻿using Microsoft.Extensions.Options;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using System.Net.Mail;
using System.Text;
using static TempleVolunteerAPI.Common.EnumHelper;
using System.Net;

namespace TempleVolunteerAPI.Service
{
    public class EmailService : IEmailService
    {
        private readonly AppSettings _appSettings;
        private string _uri;
        private string _fromEmail;
        private string _smtpPwd;
        StringBuilder _message;

        public EmailService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;

            _uri = _appSettings.UriClientLocal; // _appSettings.UriLocal;
            //_uri = _appSettings.UriHiranyaloka;
            //_uri = _appSettings.UriProduction;
            _fromEmail = _appSettings.EmailFrom;
            _smtpPwd = _appSettings.SmtpPass;
        }

        public async Task<string> SendEmail(Staff request, EmailTypeEnum emailType)
        {
            
            try
            {
                switch (emailType)
                {
                    case EmailTypeEnum.EmailExists:
                    {
                            _message = new StringBuilder("<h4>Email Already Registered</h4>");
                            _message.AppendFormat("Hello {0} - if you don't know your password please click: ", request.FirstName);
                            _message.AppendFormat("<a href={0}/Account/ForgotPassword?emailAddress={1}>Forgot Password</a>", _uri, request.EmailAddress);
                            await Send(request.EmailAddress, "Temple Volunteer - Already Registered", _message.ToString(), _fromEmail, request.PropertyId);

                            return "Temple Volunteer - Email Already Registered";
                        }
                        break;

                    case EmailTypeEnum.RegisterEmail:
                        {
                            _message = new StringBuilder("<h4>Registration</h4>");
                            _message.AppendFormat("Hello {0} - your registration has been submitted. You will receive an email once your registration as been approved.", request.FirstName);
                            _message.Append("<p></p>");
                            _message.Append("Thank you.");
                            await Send(request.EmailAddress, "Temple Volunteer - Register", _message.ToString(), _fromEmail, request.PropertyId);

                            return "Temple Volunteer - Registration Submittal Successful - Please Check Your Email";
                        }
                        break;

                    case EmailTypeEnum.RegistrationApproved:
                        {
                            _message = new StringBuilder("<h4>Registration Approved</h4>");
                            _message.AppendFormat("Hello {0} - your registrtion has been approved.", request.FirstName);
                            _message.Append("<p></p>");
                            _message.Append("Please click the link below to login: ");
                            _message.AppendFormat("<a href={0}/Account/VerifyEmailAddress?emailAddress={1}&propertyId={2}> Complete Registration </a>", _uri, request.EmailAddress, request.PropertyId);
                            await Send(request.EmailAddress, "Temple Volunteer - Registration Approved", _message.ToString(), _fromEmail, request.PropertyId);

                            return "Temple Volunteer - Registration Approval Sent";
                        }
                        break;

                    case EmailTypeEnum.ResetPassword:
                        {
                            _message = new StringBuilder("<h4>Reset Password</h4>");
                            _message.AppendFormat("Hello {0} - please click the below link to reset your password. This link will be valid for 3 days: ", request.FirstName);
                            _message.AppendFormat("<a href={0}/Account/ResetPassword?emailAddress={1}>Reset Password</a>", _uri, request.EmailAddress);
                            await Send(request.EmailAddress, "Temple Volunteer - Reset Password", _message.ToString(), _fromEmail, request.PropertyId);

                            return "Temple Volunteer - Reset Password Successful";
                        }
                        break;

                    case EmailTypeEnum.ForgotPassword:
                        {
                            _message = new StringBuilder("<h4>Forgot Password</h4>");
                            _message.AppendFormat("Greetings {0} - please click the below link to reset your password. This link will be valid for 3 days: ", request.FirstName);
                            _message.AppendFormat("<a href={0}/Account/ResetForgottenPassword?emailAddress={1}&PropertyId={2}>Reset Password</a>", _uri, request.EmailAddress, request.PropertyId);
                            await Send(request.EmailAddress, "Temple Volunteer - Forgot Password", _message.ToString(), _fromEmail, request.PropertyId);

                            return "Temple Volunteer - Reset Password Successful";
                        }
                        break;
                }

                return "true";
            }
            catch (Exception ex)
            {
                throw new AppException("Unable to send verification email (Service: SendVerificationEmail)");
            }
        }

        public async Task<bool> Send(string toEmail, string subject, string body, string fromEmail, int propertyId)
        {
            using (var message = new MailMessage())
            {
                message.From = new MailAddress(fromEmail, "Temple Volunteer");
                message.To.Add(new MailAddress(toEmail, ""));
                //message.CC.Add(new MailAddress("cc@email.com", "CC Name"));
                //message.Bcc.Add(new MailAddress("bcc@email.com", "BCC Name"));
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential(fromEmail, _smtpPwd);
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }

            return true;
        }
    }
}
