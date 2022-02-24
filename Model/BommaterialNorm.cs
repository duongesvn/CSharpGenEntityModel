using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class BommaterialNorm
    {
        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public string MaterialItemId { get; set; }
        public string ChangeItemId { get; set; }
        public string Description { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PercentLoss { get; set; }
        public decimal? QuantityLoss { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string CodeType { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? RowGuid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid? BomworkpiecesGuid { get; set; }
        public decimal? L1 { get; set; }
        public decimal? L2 { get; set; }
        public decimal? L3 { get; set; }
        public decimal? L4 { get; set; }
        public decimal? L5 { get; set; }
        public decimal? L6 { get; set; }
        public decimal? L7 { get; set; }
        public decimal? L8 { get; set; }
        public decimal? L9 { get; set; }
        public decimal? L10 { get; set; }
        public decimal? L11 { get; set; }
        public decimal? L12 { get; set; }
        public decimal? L13 { get; set; }
        public decimal? L14 { get; set; }
        public decimal? L15 { get; set; }
        public decimal? L16 { get; set; }
        public decimal? L17 { get; set; }
        public decimal? L18 { get; set; }
        public decimal? L19 { get; set; }
        public decimal? L20 { get; set; }
        public decimal? Cavity { get; set; }
        public decimal? CycleTime { get; set; }
        public decimal? ApecificGravity { get; set; }
        public decimal? High { get; set; }
        public decimal? Length { get; set; }
        public decimal? Wide { get; set; }
        public decimal? SizeOd { get; set; }
        public decimal? SizeId { get; set; }
        public string Shape { get; set; }

        public virtual Bomcategory Bomcategory { get; set; }
    }
}
