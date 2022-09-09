using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TempleVolunteerAPI.Domain
{
    [Owned]
    public class RefreshTokens
    {
        [Key]
        public int Id { get; set; }
        public string? Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Revoked { get; set; }
        public string? RevokedBy { get; set; }
        public string? ReplacedByToken { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;

        #region Dependencies
        //public Staff Staff { get; set; }
        #endregion
    }
}
