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
        public virtual ICollection<EventEventType> EventsEventTypes { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
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
            this.EventsEventTypes = new List<EventEventType>();
        }
        #endregion
    }
}
