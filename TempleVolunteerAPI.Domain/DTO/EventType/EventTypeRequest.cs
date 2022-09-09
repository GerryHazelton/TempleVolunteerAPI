﻿namespace TempleVolunteerAPI.Domain
{
    public class EventTypeRequest : Audit
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int PropertyId { get; set; }

        public ICollection<Area> Areas { get; set; }

        public EventTypeRequest()
        {
            this.Areas = new HashSet<Area>();

        }
    }
}
