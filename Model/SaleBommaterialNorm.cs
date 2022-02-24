using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleBommaterialNorm
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
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? RowGuid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid? SaleBomworkpiecesGuid { get; set; }

        public virtual SaleBomcategory SaleBomcategory { get; set; }
    }
}
