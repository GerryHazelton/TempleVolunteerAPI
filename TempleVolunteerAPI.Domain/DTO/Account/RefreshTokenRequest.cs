namespace TempleVolunteerAPI.Domain
{
    public class RefreshTokenRequest : Audit
    {
        public int UserId { get; set; }
        public string RefreshToken { get; set; }
    }
}
