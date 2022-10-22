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
            ResetPassword,
            VerifyEmail
        }

        public enum WithDetails
        {
            AreaEventTask,
            AreaEventType,
            AreaSupplyItem,
            CredentialStaff,
            EventEventType,
            None,
            PropertyStaff,
            RefreshTokenStaff,
            RoleStaff
        }
    }
}
