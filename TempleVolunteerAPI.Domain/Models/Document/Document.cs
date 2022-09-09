using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Document : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        [StringLength(150)]
        public string? DocumentFileName { get; set; }

        public byte[]? DocumentImage { get; set; }

        #region Dependencies
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        #endregion

        #region Constructors
        public Document()
        {
        }

        public Document(string createdBy)
            : base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
        }
        #endregion
    }
}
