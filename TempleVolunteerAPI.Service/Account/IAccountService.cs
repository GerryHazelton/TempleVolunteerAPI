using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TempleVolunteerAPI.Service
{
    public interface IAccountService
    {
        Task<RegisterResponse> RegisterAsync(RegisterRequest model);
        Task<TokenResponse> LoginAsync(LoginRequest request);
        Task<ServiceResponse<Staff>> ForgotPasswordAsync(ForgotPasswordRequest model);
        Task<ServiceResponse<Staff>> ResetPasswordAsync(ResetPasswordRequest model);
        Task<int> RecordLoginAttempts(string userId, int propertyId);
        Task<bool> ResetLoginAttempts(string userId, int propertyId);

    }
}
