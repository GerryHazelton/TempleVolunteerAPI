using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Committee : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommitteeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
 
        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        #region Dependencies
        public virtual Property Property { get; set; }
        public virtual ICollection<AreaCommittee> Areas { get; set; }
        public virtual ICollection<CommitteeStaff> Staff { get; set; }
        #endregion

        #region Constructors
        public Committee()
        {
        }

        public Committee(string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Areas = new List<AreaCommittee>();
            this.Staff = new List<CommitteeStaff>();
        }
        #endregion
    }
}
