namespace TempleVolunteerAPI.Domain
{
    public class EventTaskRequest : Audit
    {
        public int EventTaskId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
    }
}
