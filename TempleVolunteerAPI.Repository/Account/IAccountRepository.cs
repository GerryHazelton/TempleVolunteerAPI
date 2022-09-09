using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public interface IAccountRepository
    {
        public Task<ServiceResponse<int>> AddRegistration(Staff register);
        public Task<ServiceResponse<string>> GetLogin(string emailAddress, string password);
        public Task<bool> UserExists(string emailAddress);
        public Task<Staff> GetByEmailAddressAsync(string emailAddress);
    }
}
