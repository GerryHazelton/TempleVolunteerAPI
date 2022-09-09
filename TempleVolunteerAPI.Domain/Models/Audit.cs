using System.ComponentModel.DataAnnotations;

namespace TempleVolunteerAPI.Domain
{
    public class Audit
    {
        [StringLength(75)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(75)]
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set;}
        public bool IsHidden { get; set; }

        public Audit()
        {
            this.CreatedDate = DateTime.UtcNow;
        }

        public Audit (string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
        }
    }
}
