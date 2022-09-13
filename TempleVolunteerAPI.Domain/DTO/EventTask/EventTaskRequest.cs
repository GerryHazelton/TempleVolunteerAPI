namespace TempleVolunteerAPI.Domain
{
    public class EventTaskRequest : Audit
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
