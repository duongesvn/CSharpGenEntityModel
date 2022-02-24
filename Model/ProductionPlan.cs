using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ProductionPlan
    {
        public ProductionPlan()
        {
            ProductionPlanDays = new HashSet<ProductionPlanDay>();
        }

        public Guid OrganizationGuid { get; set; }
        public string OrderPlanId { get; set; }
        public int? RunNumber { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string OrderItemId { get; set; }
        public string ProductionOrderNo { get; set; }
        public Guid? ProOrderProductGuid { get; set; }
        public string OrderNumber { get; set; }
        public Guid? OrderDetailGuid { get; set; }
        public string Bomnumber { get; set; }
        public string UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? Status { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedNote { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsCancel { get; set; }
        public string CancelName { get; set; }
        public DateTime? CancelDate { get; set; }
        public string CancelReason { get; set; }
        public Guid? RowGuid { get; set; }
        public string Note { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string Cof { get; set; }
        public decimal? Cavity { get; set; }
        public decimal? CycTime { get; set; }
        public decimal? LastStock { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<ProductionPlanDay> ProductionPlanDays { get; set; }
    }
}
