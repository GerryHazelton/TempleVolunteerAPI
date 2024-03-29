﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class RefreshToken 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RefreshTokenId { get; set; }
        public int UserId { get; set; }
        public string TokenHash { get; set; }
        public string TokenSalt { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int PropertyId { get; set; }

        #region Dependencies
        [ForeignKey(nameof(Staff))]
        public int? StaffId { get; set; }
        public Staff? Staff { get; set; }
        #endregion

        #region Constructors
        public RefreshToken()
        {
        }
        #endregion
    }
}
