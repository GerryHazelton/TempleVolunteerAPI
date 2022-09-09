namespace TempleVolunteerAPI.Domain
{
    public class Login
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string RoleNames { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsError { get; set; }
        public int PropertyId { get; set; }
    }
}
