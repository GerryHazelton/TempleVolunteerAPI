namespace TempleVolunteerAPI.Domain
{
    public class VerifyEmailAddressRequest
    {
        public string? EmailAddress { get; set; }
        public string? Token { get; set; }
        public int StaffId { get; set; }
        public int PropertyId { get; set; }
    }
}
