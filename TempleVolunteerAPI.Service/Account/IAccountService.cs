using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;
using TempleVolunteerAPI.Common;

namespace TempleVolunteerAPI.Service
{
    public interface IAccountService
    {
        Task<RegisterResponse> RegisterAsync(Staff staff);
        Task<TokenResponse> LoginAsync(LoginRequest request);
        Task<RepositoryResponse<MyProfileRequest>> MyProfileAsync(MyProfileRequest request);
        Task<ServiceResponse<Staff>> VerifyEmailAddressAsync(VerifyEmailAddressRequest request);
        Task<ServiceResponse<Staff>> ForgotPasswordAsync(ForgotPasswordRequest request);
        Task<ServiceResponse<Staff>> ResetForgotenPasswordAsync(ResetForgottenPasswordRequest request);
        Task<ServiceResponse<Staff>> ResetPasswordAsync(ResetPasswordRequest request);
        Task RecordLoginAttempts(string userId, int propertyId);
        Task ResetLoginAttempts(string userId, int propertyId);
        void AddTemporaryPassword(int staffId, string password);
        string GetTemporaryPassword(int staffId);
        void DeleteTemporaryPassword(int staffId);
    }
}
