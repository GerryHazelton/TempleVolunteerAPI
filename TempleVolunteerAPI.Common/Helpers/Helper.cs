using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace TempleVolunteerAPI.Common
{
    #region Enums
    public enum AreaType
    {
        BallField = 1,
        Chapel,
        Classroom,
        EventRoom,
        Garden,
        MeetingEventType,
        Office,
        OutDoor,
        Other
    }

    public enum SendEmailType
    {
        Register,
        ForgotPassword
    }

    public enum ContentType
    {
        Doc = 1,
        Docx = 2,
        Pdf = 3,
        Jpg = 4,
        Gif = 5,
        Png = 6
    }
    #endregion

    public class AppException : Exception
    {
        public AppException() : base() { }
        public AppException(string message) : base(message) { }
        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }

    public class Helper
    {
        public static List<string> GetParsedRoles(string roles)
        {
            return roles.Split(',').ToList();
        }

        public static string GetFileName(string fileName)
        {
            char[] fileNameArray = fileName.ToCharArray();
            Array.Reverse(fileNameArray);
            string tmpFileName = new String(fileNameArray);

            //int index = tmpFileName.IndexOf("\\", 0);
            int index = tmpFileName.IndexOf("/", 0);

            if (index > -1)
            {
                tmpFileName = tmpFileName.Substring(0, index);
                fileNameArray = tmpFileName.ToCharArray();
                Array.Reverse(fileNameArray);
            }
            else
            {
                return fileName;
            }

            return new String(fileNameArray);
        }

        public static string RandomTokenString(string userId)
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);

            return BitConverter.ToString(randomBytes).Replace("-", "");
        }

        public static string GetPasswordHash(string password, string userId)
        {
            using (var md5 = MD5.Create())
            {
                byte[]? passwordBytes = Encoding.ASCII.GetBytes(password);
                byte[]? hash = md5.ComputeHash(passwordBytes);
                var sbHash = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sbHash.Append(hash[i].ToString("X2"));
                }

                return sbHash.ToString();
            }
        }

        public static byte[] GetSecureSalt()
        {
            return RandomNumberGenerator.GetBytes(32);
        }
  
        public static string HashUsingPbkdf2(string password, byte[] salt)
        {
            byte[] derivedKey = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, iterationCount: 100000, 32);

            return Convert.ToBase64String(derivedKey);
        }
    }
}
