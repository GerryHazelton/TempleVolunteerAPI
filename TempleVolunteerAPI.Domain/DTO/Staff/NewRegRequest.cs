namespace TempleVolunteerAPI.Domain
{
    public class NewRegRequest : Audit
    {
        public int StaffId { get; set; }
        public bool Approve { get; set; }
    }
}
