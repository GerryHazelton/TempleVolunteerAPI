using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Event : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        public DateTime? StartDate { get; set; }
 
        public DateTime? EndDate { get; set; }

        public bool Indefinite { get; set; }
 
        #region Dependencis
        public virtual ICollection<AreaEventType> Areas { get; set; }
        public virtual ICollection<EventEventType> EventTypes { get; set; }

        [ForeignKey(nameof(Area))]
        public int? AreaId { get; set; }
        public Area? Area { get; set; }
        [ForeignKey(nameof(Property))]
        public int? PropertyId { get; set; }
        public Property? Property { get; set; }

        #endregion

        #region Constructors
        public Event()
        {
        }

        public Event(string createdBy)
            : base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Areas = new List<AreaEventType>();
            this.EventTypes = new List<EventEventType>();
        }
        #endregion
    }
}
