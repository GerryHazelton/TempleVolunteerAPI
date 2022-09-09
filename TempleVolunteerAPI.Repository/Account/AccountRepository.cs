using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _uow;

        public AccountRepository(ApplicationDBContext context, IConfiguration configuration, IUnitOfWork uow)
        {
            _configuration = configuration;
            _context = context;
            _uow = uow;
        }

        public async Task<ServiceResponse<int>> AddRegistration(Staff register)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();

            try
            {
                await _context.Set<Staff>().AddAsync(register);
                await _uow.CommitAsync();

                response.Data = register.StaffId;
                response.Success = true;
                response.Message = String.Empty;

                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;

                return response;
            }
        }

        public async Task<ServiceResponse<string>> GetLogin(string emailAddress, string password)
        {
            ServiceResponse<string> response = new ServiceResponse<string>();

            try
            {
                Staff staff = await _context.Set<Staff>().SingleOrDefaultAsync(x => x.EmailAddress == emailAddress);

                if (staff == null)
                {
                    response.Success = false;
                    response.Message = "User not found.";
                    return response;
                }

                var passwordHash = Helper.HashUsingPbkdf2(password, Convert.FromBase64String(staff.PasswordSalt));

                if (staff.Password != passwordHash)
                {
                    response.Success = false;
                    response.Message = "Wrong password";
                    return response;
                }

                response.Data = CreateToken(staff);
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }



        public async Task<bool> UserExists(string emailAddress)
        {
            try
            {
                Staff staff = await _context.Staff.SingleOrDefaultAsync(x => x.EmailAddress == emailAddress);

                if (staff == null)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CreatePasswordHash(string password, out byte[]? passwordHash, out byte[]? passwordSalt)
        {
            try
            {
                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    passwordSalt = hmac.Key;
                    passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerifyPasswordHash(string password, byte[]? passwordHash, byte[]? passwordSalt)
        {
            try
            {
                using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
                {
                    var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                    for (int i = 0; i < computedHash.Length; i++)
                    {
                        if (computedHash[i] != passwordHash[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string CreateToken(Staff appliactionUser)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, appliactionUser.StaffId.ToString()),
                new Claim(ClaimTypes.Name, appliactionUser.EmailAddress)
            };

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = creds
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public async Task<Staff> GetByEmailAddressAsync(string emailAddress)
        {
            try
            {
                return await _context.Staff.SingleOrDefaultAsync(x => x.EmailAddress == emailAddress);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
