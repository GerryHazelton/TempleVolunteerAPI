
using Microsoft.Extensions.DependencyInjection;
using TempleVolunteerAPI.API;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.Tests
{
    [TestClass]
    public class AccountTests
    {
        private readonly string _userId = "gerryhazelton@gmail.com";
        private readonly IAccountService _service;

        public AccountTests(IAccountService service)
        {
            _service = service;
        }

        [TestMethod]
        public void CreateVolunteer()
        {
            RegisterResponse staff = new RegisterResponse();
            staff.FirstName = "Gerry";
            staff.LastName = "Hazelton";
            staff.Address = "123 Main Street";
            staff.Address2 = "Apt. B";
            staff.City = "Carlsbad";
            staff.State = "CA";
            staff.PostalCode = "92009";
            staff.Country = "US";
            staff.PhoneNumber = "555-555-5555";
            staff.EmailAddress = _userId;

            try
            {
                _service.RegisterAsync(staff);
            }
            catch
            {
                throw;
            }

            Assert.IsNotNull(staff, "Staff is not null");
        }
    }
}