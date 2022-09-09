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
        public virtual ICollection<EventTask> EventTasks { get; set; }
        public virtual ICollection<EventType> EventTypes { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public virtual ICollection<SupplyItem> SupplyItems { get; set; }
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
            this.EventTasks = new HashSet<EventTask>();
            this.EventTypes = new HashSet<EventType>();
            this.SupplyItems = new HashSet<SupplyItem>();
        }
        #endregion
    }
}
