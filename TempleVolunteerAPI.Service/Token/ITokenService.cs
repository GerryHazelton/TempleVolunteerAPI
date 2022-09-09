using TempleVolunteerAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleVolunteerAPI.Service
{
    public interface ITokenService
    {
        Task<Tuple<string, string>> GenerateTokensAsync(int userId);
        Task<ValidateRefreshTokenResponse> ValidateRefreshTokenAsync(RefreshTokenRequest refreshTokenRequest);
        Task<bool> RemoveRefreshTokenAsync(Staff staff);
    }
}
