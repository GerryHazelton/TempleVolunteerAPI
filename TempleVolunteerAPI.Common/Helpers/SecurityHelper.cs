using System.Security.Cryptography;

namespace TempleVolunteerAPI.Common
{
    public class SecurityHelper
    {
        public static string GenerateSalt(int nSalt)
        {
            var saltBytes = new byte[nSalt];

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.EncryptValue(saltBytes);
            }

            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt, int nIterations, int nHash)
        {
            var saltBytes = Convert.FromBase64String(salt);

            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, nIterations))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash));
            }
        }
    }
}
