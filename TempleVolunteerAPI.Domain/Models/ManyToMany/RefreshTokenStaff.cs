namespace TempleVolunteerAPI.Domain
{
    public class RefreshTokenStaff
    {
        public int RefreshTokenId { get; set; }
        public RefreshToken RefreshToken { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
