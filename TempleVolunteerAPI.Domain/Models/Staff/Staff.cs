using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Staff : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(25)]
        public string LastName { get; set; }

        [StringLength(75)]
        public string Address { get; set; }

        [StringLength(25)]
        public string? Address2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(2)]
        public string? State { get; set; }

        [StringLength(15)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(75)]
        public string EmailAddress { get; set; }

        [StringLength(25)]
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public bool FirstAid { get; set; }
        public bool CPR { get; set; }
        public bool LessonStudent { get; set; }
        public bool Kriyaban { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        public bool CanSendMessages { get; set; }
        public bool CanViewDocuments { get; set; }

        [StringLength(150)]
        public string? StaffFileName { get; set; }

        public string? StaffImage { get; set; }
        public bool AcceptTerms { get; set; }

        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool RememberMe { get; set; }
        public bool IsLockedOut { get; set; }
        public int LoginAttempts { get; set; }

        [NotMapped]
        public bool UnlockUser { get; set; }

        public DateTime? VerifiedDate { get; set; }
        public bool IsVerified { get; set; }
        public DateTime? PasswordReset { get; set; }

        #region Dependencies
        public virtual ICollection<Credential> Credentials { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        #endregion

        #region Constructor
        public Staff()
        {
        }

        public Staff(string createdBy) :
            base(createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Credentials = new HashSet<Credential>();
            this.RefreshTokens = new HashSet<RefreshToken>();
            this.Roles = new HashSet<Role>();
            this.Properties = new HashSet<Property>();
        }
        #endregion
    }
}
