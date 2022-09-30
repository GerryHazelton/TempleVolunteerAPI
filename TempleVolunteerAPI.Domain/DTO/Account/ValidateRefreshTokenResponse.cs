namespace TempleVolunteerAPI.Domain
{
    public class ValidateRefreshTokenResponse : BaseResponse
    {
        public int UserId { get; set; }
        public int PropertyId { get; set; }
    }
}
