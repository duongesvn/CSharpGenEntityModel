using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleBomcategory
    {
        public SaleBomcategory()
        {
            SaleBomcamSheets = new HashSet<SaleBomcamSheet>();
            SaleBomcategoryHistories = new HashSet<SaleBomcategoryHistory>();
            SaleBomcostNormHistories = new HashSet<SaleBomcostNormHistory>();
            SaleBommaterialNorms = new HashSet<SaleBommaterialNorm>();
            SaleBomworkOrderRoutings = new HashSet<SaleBomworkOrderRouting>();
            SaleBomworkpieces = new HashSet<SaleBomworkpiece>();
            SaleProductCostNorms = new HashSet<SaleProductCostNorm>();
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
        public string Status { get; set; }
        public string ItemParentId { get; set; }

        public virtual SaleItemWaitingQuotation SaleItemWaitingQuotation { get; set; }
        public virtual ICollection<SaleBomcamSheet> SaleBomcamSheets { get; set; }
        public virtual ICollection<SaleBomcategoryHistory> SaleBomcategoryHistories { get; set; }
        public virtual ICollection<SaleBomcostNormHistory> SaleBomcostNormHistories { get; set; }
        public virtual ICollection<SaleBommaterialNorm> SaleBommaterialNorms { get; set; }
        public virtual ICollection<SaleBomworkOrderRouting> SaleBomworkOrderRoutings { get; set; }
        public virtual ICollection<SaleBomworkpiece> SaleBomworkpieces { get; set; }
        public virtual ICollection<SaleProductCostNorm> SaleProductCostNorms { get; set; }
    }
}
