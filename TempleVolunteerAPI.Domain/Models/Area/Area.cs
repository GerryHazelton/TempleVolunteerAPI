using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Area : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AreaId { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(250)]
        public string? Description { get; set; }
        
        public bool SupplyItemsAllowed { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        #region Dependencies
        public ICollection<AreaEventTask> EventTasks { get; set; }
        public ICollection<AreaEventType> EventTypes { get; set; }
        [ForeignKey(nameof(Property))]
        public int? PropertyId { get; set; }
        public Property? Property { get; set; }
        public ICollection<AreaSupplyItem> SupplyItems { get; set; }
        #endregion

        #region Constructors
        public Area()
        {
        }

        public Area(string createdBy) :
            base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.EventTasks = new List<AreaEventTask>();
            this.EventTypes = new List<AreaEventType>();
            this.SupplyItems = new List<AreaSupplyItem>();
        }
        #endregion
    }
}
