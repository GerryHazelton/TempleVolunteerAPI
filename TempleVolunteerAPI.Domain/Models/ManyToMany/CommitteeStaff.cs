namespace TempleVolunteerAPI.Domain
{
    public class CommitteeStaff
    {
        public int StaffId { get; set; }
        public Staff? Staff { get; set; }
        public int CommitteeId { get; set; }
        public Committee? Committee { get; set; }
    }
}
