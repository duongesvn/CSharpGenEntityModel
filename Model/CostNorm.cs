using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class CostNorm
    {
        public Guid OrganizationGuid { get; set; }
        public string CostId { get; set; }
        public DateTime StartDate { get; set; }
        public string Title { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal? Rate { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? InsuranceCostPrice { get; set; }
        public string Type { get; set; }
        public string Nature { get; set; }
        public string ParentCostId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefaultValue { get; set; }
        public bool? IsBoldFont { get; set; }
        public bool? IsItalicFont { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? CostNormGuid { get; set; }
    }
}
