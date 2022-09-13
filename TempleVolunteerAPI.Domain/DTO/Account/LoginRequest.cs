namespace TempleVolunteerAPI.Domain
{
    public class LoginRequest : Audit
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
