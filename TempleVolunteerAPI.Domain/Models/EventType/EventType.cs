using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class EventType : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventTypeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        #region Dependencies
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        #endregion

        #region Constructors
        public EventType()
        {
        }

        public EventType(string createdBy)
            : base(createdBy)
        {
            this.Areas = new HashSet<Area>();
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Events = new HashSet<Event>();
        }
        #endregion
    }
}
