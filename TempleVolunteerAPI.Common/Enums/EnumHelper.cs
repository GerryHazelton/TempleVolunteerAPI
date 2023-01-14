using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleVolunteerAPI.Common
{
    public static class EnumHelper
    {
        public enum EmailTypeEnum
        {
            EmailExists,
            ForgotPassword,
            RegisterEmail,
            RegistrationApproved,
            ResetPassword,
            VerifyEmail
        }

        public enum WithDetails
        {
            Yes,
            No
        }
    }
}
