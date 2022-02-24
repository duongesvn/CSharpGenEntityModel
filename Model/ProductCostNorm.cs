using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ProductCostNorm
    {
        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public string CostId { get; set; }
        public string CostName { get; set; }
        public string Type { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? InsuranceCostPrice { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsBoldFont { get; set; }
        public bool? IsItalicFont { get; set; }
        public int? SortOrder { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? RowGuid { get; set; }

        public virtual Bomcategory Bomcategory { get; set; }
    }
}
