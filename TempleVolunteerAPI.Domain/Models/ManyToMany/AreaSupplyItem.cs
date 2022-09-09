namespace TempleVolunteerAPI.Domain
{
    public class AreaSupplyItem
    {
        public int AreaId { get; set; }
        public Area? Area { get; set; }
        public int SupplyItemId { get; set; }
        public SupplyItem? SupplyItem { get; set; }
        public int PropertyId { get; set; }

    }
}
