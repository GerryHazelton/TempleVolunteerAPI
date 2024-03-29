﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleVolunteerAPI.Domain
{
    public class SupplyItem : Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplyItemId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
 
        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(250)]
        public string? Note { get; set; }

        public int Quantity { get; set; }

        [StringLength(25)]
        public string? BinNumber { get; set; }

        [StringLength(150)]
        public string? SupplyItemFileName { get; set; }

        public byte[]? SupplyItemImage { get; set; }

        #region Dependencies
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<AreaSupplyItem> Areas { get; set; }
        public Property? Property { get; set; }
        #endregion

        #region Constructors
        public SupplyItem()
        {
        }

        public SupplyItem(string createdBy)
        {
            this.CreatedBy = createdBy;
            this.CreatedDate = DateTime.UtcNow;
            this.Areas = new List<AreaSupplyItem>();
        }
        #endregion
    }
}
