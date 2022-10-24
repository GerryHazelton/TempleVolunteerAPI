namespace TempleVolunteerAPI.Domain
{
    public class EventTypeArea
    {
        public int AreaId { get; set; }
        public Area? Area { get; set; }
        public int EventTypeId { get; set; }
        public EventType? EventType { get; set; }
        public int PropertyId { get; set; }

    }
}
