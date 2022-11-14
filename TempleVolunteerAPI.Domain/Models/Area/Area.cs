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
        public Property? Property { get; set; }
        public virtual ICollection<AreaCommittee> Committees { get; set; }
        public virtual ICollection<AreaEventTask> EventTasks { get; set; }
        public virtual ICollection<EventTypeArea> EventTypes { get; set; }
        public ICollection<AreaSupplyItem> SupplyItems { get; set; }
        #endregion

        #region Constructors
        public Area()
        {
        }

        public Area(string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Committees = new List<AreaCommittee>();
            this.EventTasks = new List<AreaEventTask>();
            this.EventTypes = new List<EventTypeArea>();
            this.SupplyItems = new List<AreaSupplyItem>();
        }
        #endregion
    }
}
