namespace TempleVolunteerAPI.Domain
{
    public class AreaCommittee
    {
        public int AreaId { get; set; }
        public Area? Area { get; set; }
        public int CommitteeId { get; set; }
        public Committee? Committee { get; set; }
        public int PropertyId { get; set; }
    }
}
