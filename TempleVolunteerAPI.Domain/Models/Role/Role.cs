using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Role : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        #region Dependencies
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public virtual ICollection<RoleStaff> Staff { get; set; }

        #endregion

        #region Constructor
        public Role()
        {
        }

        public Role(string createdBy) :
            base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Staff = new List<RoleStaff>();
        }
        #endregion
    }
}
