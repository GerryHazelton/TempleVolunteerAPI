using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Credential : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CredentialId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
 
        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        #region Dependencies
        public virtual Property Property { get; set; }
        public virtual ICollection<StaffCredential> Staff { get; set; }

        #endregion

        #region Constructors
        public Credential()
        {
        }

        public Credential(string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Staff = new List<StaffCredential>();
        }
        #endregion
    }
}
