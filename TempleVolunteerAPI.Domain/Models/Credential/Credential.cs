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


        [StringLength(150)]
        public string? CredentialFileName { get; set; }

        public byte[]? CredentialImage { get; set; }

        public DateTime? CompletedDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        #region Dependencies
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }

        #endregion

        #region Constructors
        public Credential()
        {
        }

        public Credential(string createdBy)
            : base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Staff = new HashSet<Staff>();
        }
        #endregion
    }
}
