using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class EventTask : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventTaskId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }


        #region Dependencies
        public virtual ICollection<AreaEventTask> Areas { get; set; }
        [ForeignKey(nameof(Property))]
        public int? PropertyId { get; set; }
        public Property? Property { get; set; }

        #endregion

        #region Constructors
        public EventTask()
        {
        }

        public EventTask(string createdBy)
            : base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Areas = new List<AreaEventTask>();
        }
        #endregion
    }
}
