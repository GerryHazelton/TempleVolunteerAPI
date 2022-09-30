using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using TempleVolunteerAPI.Domain.DTO;

namespace TempleVolunteerAPI.Service
{
    public interface IAccountService
    {
        Task<RegisterResponse> RegisterAsync(RegisterRequest request);
        Task<TokenResponse> LoginAsync(LoginRequest request);
        Task<RepositoryResponse<MyProfileRequest>> MyProfileAsync(MyProfileRequest request);
        Task<ServiceResponse<Staff>> ForgotPasswordAsync(ForgotPasswordRequest request);
        Task<ServiceResponse<Staff>> ResetPasswordAsync(ResetPasswordRequest request);
        Task<ServiceResponse<Staff>> ResetForgotenPasswordAsync(ResetForgottenPasswordRequest request);
        Task<int> RecordLoginAttempts(string userId, int propertyId);
        Task<bool> ResetLoginAttempts(string userId, int propertyId);

    }
}
