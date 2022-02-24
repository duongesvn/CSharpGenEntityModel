using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ProductionPlanDay
    {
        public ProductionPlanDay()
        {
            JobCards = new HashSet<JobCard>();
            PlanResources = new HashSet<PlanResource>();
        }

        public Guid OrganizationGuid { get; set; }
        public Guid PlanDayGuid { get; set; }
        public Guid? HeaderGuid { get; set; }
        public string OrderPlanDay { get; set; }
        public string OrderPlanId { get; set; }
        public DateTime? PlanDate { get; set; }
        public int? PlanDateInt { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string PartItemId { get; set; }
        public string PartItemName { get; set; }
        public Guid? WoroutingGuid { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public Guid? CamSheetGuid { get; set; }
        public string CamSheetId { get; set; }
        public string MachineId { get; set; }
        public string OrderItemId { get; set; }
        public string ProductionOrderNo { get; set; }
        public Guid? ProOrderProductGuid { get; set; }
        public string OrderNumber { get; set; }
        public Guid? OrderDetailGuid { get; set; }
        public string Bomnumber { get; set; }
        public string LotNumber { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? QuantityHourse { get; set; }
        public int? ProductionTime { get; set; }
        public int? ProductionTime3 { get; set; }
        public double? CycleTime { get; set; }
        public string MoldTime { get; set; }
        public string MoldCode { get; set; }
        public decimal? QuantityOk { get; set; }
        public decimal? QuantityNg { get; set; }
        public decimal? QuantityTest { get; set; }
        public int? RunNumber { get; set; }
        public bool? IsPause { get; set; }
        public string PauseName { get; set; }
        public string PauseNote { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? SortOrder { get; set; }

        public virtual ProductionPlanDayHeader HeaderGu { get; set; }
        public virtual ProductionPlan Or { get; set; }
        public virtual ICollection<JobCard> JobCards { get; set; }
        public virtual ICollection<PlanResource> PlanResources { get; set; }
    }
}
