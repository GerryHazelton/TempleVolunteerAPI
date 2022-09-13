namespace TempleVolunteerAPI.Domain
{
    public class ForgotPasswordRequest : Audit
    {
        public string? EmailAddress { get; set; }
        public string? PostalCode { get; set; }
    }
}
