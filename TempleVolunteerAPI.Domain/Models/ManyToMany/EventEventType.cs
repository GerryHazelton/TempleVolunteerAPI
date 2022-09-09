namespace TempleVolunteerAPI.Domain
{
    public class EventEventType
    {
        public int EventId { get; set; }
        public Event? Event { get; set; }
        public int EventTypeId { get; set; }
        public EventType? EventType { get; set; }
        public int PropertyId { get; set; }

    }
}
