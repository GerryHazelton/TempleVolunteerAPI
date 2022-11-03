﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class Audit
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsHidden { get; set; }
        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }

        public Audit()
        {
            this.CreatedDate = DateTime.Now;
        }

        public Audit(string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.Now;
        }
    }
}
