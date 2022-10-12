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
        public ICollection<AreaEventTask> AreasEventTasks { get; set; }
        public ICollection<AreaEventType> AreaEventTypes { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public ICollection<AreaSupplyItem> AreasSupplyItems { get; set; }
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
            this.AreasEventTasks = new List<AreaEventTask>();
            this.AreaEventTypes = new List<AreaEventType>();
            this.AreasSupplyItems = new List<AreaSupplyItem>();
        }
        #endregion
    }
}
