﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class ErrorLog : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorLogId { get; set; }

        [StringLength(150)]
        public string FunctionName { get; set; }

        [StringLength(500)]
        public string ErrorMessage { get; set; }
 
        [StringLength(3000)]
        public string StackTrace { get; set; }

        [StringLength(6)]
        public string? Environment { get; set; }

        #region Constructors
        public ErrorLog()
        {
        }

        public ErrorLog(string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
        }
        #endregion
    }
}
