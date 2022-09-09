using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Message : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        [StringLength(75)]
        public string From { get; set; }

        [StringLength(75)]
        public string To { get; set; }

        [StringLength(75)]
        public string Subject { get; set; }

        [StringLength(250)]
        public string MessageSent { get; set; }

        public int StaffId { get; set; }

        #region Dependencies
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        #endregion

        #region Constructors
        public Message()
        {
        }

        public Message(string createdBy)
            : base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
        }
        #endregion
    }
}
