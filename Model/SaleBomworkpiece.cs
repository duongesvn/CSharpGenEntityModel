using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleBomworkpiece
    {
        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public string LocationId { get; set; }
        public string MaterialItemId { get; set; }
        public string Shape { get; set; }
        public decimal ApecificGravity { get; set; }
        public decimal? High { get; set; }
        public decimal? Length { get; set; }
        public decimal? Wide { get; set; }
        public decimal? SizeOd { get; set; }
        public decimal? SizeId { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PercentUsed { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? ConvertRate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? RowGuid { get; set; }
        public bool? IsEdit { get; set; }

        public virtual SaleBomcategory SaleBomcategory { get; set; }
    }
}
