using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class JobCard
    {
        public JobCard()
        {
            JobCardsPqcs = new HashSet<JobCardsPqc>();
            JobCardsQcerrors = new HashSet<JobCardsQcerror>();
            ProductCosts = new HashSet<ProductCost>();
        }

        public Guid OrganizationGuid { get; set; }
        public string JobCardId { get; set; }
        public DateTime Date { get; set; }
        public int? DateInt { get; set; }
        public Guid PlanDayGuid { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string PartItemId { get; set; }
        public string PartItemName { get; set; }
        public string ProductionOrderNo { get; set; }
        public string OrderNumber { get; set; }
        public Guid? OrderDetailGuid { get; set; }
        public string LocationId { get; set; }
        public string CamSheetId { get; set; }
        public string MachineId { get; set; }
        public string OrderItemId { get; set; }
        public string LotNumber { get; set; }
        public string EmployeeId { get; set; }
        public Guid EmployeeGuid { get; set; }
        public string EmployeeName { get; set; }
        public Guid? SupportorGuid { get; set; }
        public string SupportorId { get; set; }
        public string SupportorName { get; set; }
        public Guid? DeparmentGuid { get; set; }
        public string DepartmentId { get; set; }
        public string Description { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public int? TotalMinute { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ActualTotalMinute { get; set; }
        public bool? IsRun { get; set; }
        public decimal? QuantityPlan { get; set; }
        public decimal? QuantityDelivered { get; set; }
        public decimal? QuantityDelivered3 { get; set; }
        public decimal? QuantityNg { get; set; }
        public decimal? QuantityNg3 { get; set; }
        public bool? IsReport { get; set; }
        public bool? IsQc { get; set; }
        public bool? IsPause { get; set; }
        public DateTime? PauseDate { get; set; }
        public string PauseName { get; set; }
        public string PauseNote { get; set; }
        public int? RunNumber { get; set; }
        public string Status { get; set; }
        public string ReportEmployeeName { get; set; }
        public string ReportEmployeeId { get; set; }
        public string ReportEmployeeId3 { get; set; }
        public string ReportEmployeeName3 { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? RowGuid { get; set; }
        public string Qrcode { get; set; }
        public string ReportLocationCode { get; set; }
        public string ReportReasonNg { get; set; }
        public DateTime? ReportExpectedDate { get; set; }
        public string ScrapReasonId { get; set; }
        public string ShiftId { get; set; }
        public string ShiftName { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? InsuranceCostPrice { get; set; }
        public decimal? MachineCode { get; set; }
        public decimal? MachineRunTime { get; set; }
        public decimal? MachineRunTime3 { get; set; }
        public decimal? QuantityRemaining { get; set; }
        public decimal? QuantityRemaining3 { get; set; }
        public string NoteHowToFix { get; set; }
        public string NoteHowToFix3 { get; set; }
        public string ScrapReasonId3 { get; set; }
        public string ScrapReasonNote { get; set; }
        public string ScrapReasonNote3 { get; set; }
        public string EmployeeId3 { get; set; }
        public string EmployeeName3 { get; set; }
        public string ShiftLeadName { get; set; }
        public string ShiftLeadName3 { get; set; }
        public string ShiftLeadId { get; set; }
        public string ShiftLeadId3 { get; set; }

        public virtual Location Location { get; set; }
        public virtual LotNumber LotNumberNavigation { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual ProductionPlanDay PlanDayGu { get; set; }
        public virtual ScrapReason ScrapReason { get; set; }
        public virtual ICollection<JobCardsPqc> JobCardsPqcs { get; set; }
        public virtual ICollection<JobCardsQcerror> JobCardsQcerrors { get; set; }
        public virtual ICollection<ProductCost> ProductCosts { get; set; }
    }
}
