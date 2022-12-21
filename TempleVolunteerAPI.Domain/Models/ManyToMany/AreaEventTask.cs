namespace TempleVolunteerAPI.Domain
{
    public class AreaEventTask
    {
        public int AreaId { get; set; }
        public Area? Area { get; set; }
        public int EventTaskId { get; set; }
        public EventTask? EventTask { get; set; }
        public int PropertyId { get; set; }
    }
}
