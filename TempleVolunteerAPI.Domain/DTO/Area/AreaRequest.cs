
using TempleVolunteerAPI.Common;

namespace TempleVolunteerAPI.Domain
{
    public class AreaRequest : Audit
    {
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public bool SupplyItemsAllowed { get; set; }
        public ICollection<SupplyItem> SupplyItems { get; set; }

        public AreaRequest()
        {
            this.SupplyItems = new HashSet<SupplyItem>();
        }
    }
}
