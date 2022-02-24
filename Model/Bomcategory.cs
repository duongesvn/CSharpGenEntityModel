using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class Bomcategory
    {
        public Bomcategory()
        {
            BomcategoriesPlanMixes = new HashSet<BomcategoriesPlanMix>();
            BomcategoriesTechnicals = new HashSet<BomcategoriesTechnical>();
            BomcategoryHistories = new HashSet<BomcategoryHistory>();
            BomcostNormHistories = new HashSet<BomcostNormHistory>();
            BommaterialNorms = new HashSet<BommaterialNorm>();
            BomworkOrderRoutings = new HashSet<BomworkOrderRouting>();
            Bomworkpieces = new HashSet<Bomworkpiece>();
            ProductCostNorms = new HashSet<ProductCostNorm>();
        }

        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public int RunNumber { get; set; }
        public string ItemId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ParentId { get; set; }
        public Guid? RowGuid { get; set; }
        public string FieldTypeId { get; set; }
        public string BomnumberQuotation { get; set; }
        public string Bomtype { get; set; }
        public decimal? Cavity { get; set; }
        public decimal? CycleTime { get; set; }
        public int? Ord { get; set; }

        public virtual ICollection<BomcategoriesPlanMix> BomcategoriesPlanMixes { get; set; }
        public virtual ICollection<BomcategoriesTechnical> BomcategoriesTechnicals { get; set; }
        public virtual ICollection<BomcategoryHistory> BomcategoryHistories { get; set; }
        public virtual ICollection<BomcostNormHistory> BomcostNormHistories { get; set; }
        public virtual ICollection<BommaterialNorm> BommaterialNorms { get; set; }
        public virtual ICollection<BomworkOrderRouting> BomworkOrderRoutings { get; set; }
        public virtual ICollection<Bomworkpiece> Bomworkpieces { get; set; }
        public virtual ICollection<ProductCostNorm> ProductCostNorms { get; set; }
    }
}
