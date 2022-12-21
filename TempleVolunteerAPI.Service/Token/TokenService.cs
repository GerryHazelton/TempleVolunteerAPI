using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using TempleVolunteerAPI.Common;

namespace TempleVolunteerAPI.Service
{
    public class TokenService : ITokenService
    {

        private readonly ApplicationDBContext _dbContext;

        public TokenService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Tuple<string, string>> GenerateTokensAsync(int userId, int propertyId)
        {
            var accessToken = await GenerateAccessToken(userId, propertyId);
            var refreshToken = await GenerateRefreshToken();
            var userRecord = await _dbContext.Staff.Include(o => o.RefreshTokens).FirstOrDefaultAsync(e => e.StaffId == userId);

            if (userRecord == null)
            {
                return null;
            }

            var salt = Helper.GetSecureSalt();

            var refreshTokenHashed = Helper.HashUsingPbkdf2(refreshToken, salt);

            if (userRecord.RefreshTokens != null && userRecord.RefreshTokens.Any())
            {
                await RemoveRefreshTokenAsync(userRecord, propertyId);

            }
            userRecord.RefreshTokens?.Add(new RefreshToken
            {
                ExpiryDate = DateTime.UtcNow.AddDays(30),
                CreateDate = DateTime.UtcNow,
                UserId = userId,
                PropertyId = propertyId,
                TokenHash = refreshTokenHashed,
                TokenSalt = Convert.ToBase64String(salt)

            });

            await _dbContext.SaveChangesAsync();

            var token = new Tuple<string, string>(accessToken, refreshToken);

            return token;
        }

        public async Task<bool> RemoveRefreshTokenAsync(Staff staff, int propertyId)
        {
            var userRecord = await _dbContext.Staff.Include(o => o.RefreshTokens).FirstOrDefaultAsync(e => e.StaffId == staff.StaffId && e.PropertyId == propertyId);

            if (userRecord == null)
            {
                return false;
            }

            if (userRecord.RefreshTokens != null && userRecord.RefreshTokens.Any())
            {
                var currentRefreshToken = userRecord.RefreshTokens.First();

                _dbContext.RefreshTokens.Remove(currentRefreshToken);
            }

            return false;
        }

        public async Task<ValidateRefreshTokenResponse> ValidateRefreshTokenAsync(RefreshTokenRequest refreshTokenRequest)
        {
            var refreshToken = await _dbContext.RefreshTokens.FirstOrDefaultAsync(o => o.UserId == refreshTokenRequest.UserId && o.PropertyId == refreshTokenRequest.PropertyId);

            var response = new ValidateRefreshTokenResponse();

            if (refreshToken == null)
            {
                response.Success = false;
                response.Message = "Invalid session or user is already logged out";
                response.ErrorCode = "R02";
                return response;
            }

            var refreshTokenToValidateHash = Helper.HashUsingPbkdf2(refreshTokenRequest.RefreshToken, Convert.FromBase64String(refreshToken.TokenSalt));

            if (refreshToken.TokenHash != refreshTokenToValidateHash)
            {
                response.Success = false;
                response.Message = "Invalid refresh token";
                response.ErrorCode = "R03";
                return response;
            }

            if (refreshToken.ExpiryDate < DateTime.UtcNow)
            {
                response.Success = false;
                response.Message = "Refresh token has expired";
                response.ErrorCode = "R04";
                return response;
            }

            response.Success = true;
            response.UserId = refreshToken.UserId;
            response.PropertyId = refreshToken.PropertyId;

            return response;
        }

        private static async Task<string> GenerateAccessToken(int userId, int propertyId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Convert.FromBase64String("Mataji22Mataji33Mataji44Mataji55Mataji66Mataji77Mataji88Mataji99Mataji00");

            var claimsIdentity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.SerialNumber, propertyId.ToString()),
            });

            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIdentity,
                Issuer = "http://sdportal.com",
                Audience = "http://sdportal.com",
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = signingCredentials,

            };

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);

            return await System.Threading.Tasks.Task.Run(() => tokenHandler.WriteToken(securityToken));
        }

        private static async Task<string> GenerateRefreshToken()
        {
            var secureRandomBytes = new byte[32];

            using var randomNumberGenerator = RandomNumberGenerator.Create();
            await System.Threading.Tasks.Task.Run(() => randomNumberGenerator.GetBytes(secureRandomBytes));

            var refreshToken = Convert.ToBase64String(secureRandomBytes);
            return refreshToken;
        }
    }
}
