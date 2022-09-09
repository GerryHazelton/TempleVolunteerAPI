using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Property : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropertyId { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(75)]
        public string Address { get; set; }

        [StringLength(25)]
        public string? Address2 { get; set; }

        [StringLength(75)]
        public string City { get; set; }

        [StringLength(2)]
        public string? State { get; set; }

        [StringLength(15)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(25)]
        public string PhoneNumber { get; set; }

        [StringLength(25)]
        public string? FaxNumber { get; set; }

        [StringLength(75)]
        public string EmailAddress { get; set; }

        [StringLength(150)]
        public string? Website { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        #region Dependencies
        public ICollection<Area> Areas { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Credential> Credentials { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<EventTask> EventTasks { get; set; }
        public ICollection<EventType> EventTypes { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Staff> Staff { get; set; }
        public ICollection<SupplyItem> SupplyItems { get; set; }
        #endregion

        #region Constructors
        public Property()
        {
        }

        public Property(string createdBy) :
            base(createdBy)
        {
            this.Areas = new HashSet<Area>();
            this.Categories = new HashSet<Category>();
            this.Credentials = new HashSet<Credential>();
            this.Documents = new HashSet<Document>();
            this.Events = new HashSet<Event>();
            this.EventTypes = new HashSet<EventType>();
            this.Messages = new HashSet<Message>();
            this.RefreshTokens = new HashSet<RefreshToken>();
            this.Roles = new HashSet<Role>();
            this.Staff = new HashSet<Staff>();
            this.SupplyItems = new HashSet<SupplyItem>();
            this.EventTasks = new HashSet<EventTask>();
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
        }
        #endregion
    }
}
