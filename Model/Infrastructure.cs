using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class Infrastructure
    {
        public Guid RowGuid { get; set; }
        public string InfrastructureId { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Contents { get; set; }
        public DateTime? DateInfrastructures { get; set; }
        public DateTime? DateFinish { get; set; }
        public DateTime? DateStop { get; set; }
        public int? TimesFinish { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeRequestId { get; set; }
        public decimal? RepairCosts { get; set; }
        public decimal? OutsourcingCosts { get; set; }
        public string Results { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ActualTime { get; set; }
        public int? PlanTime { get; set; }
        public int? Approve { get; set; }
        public int? ApproveStatus { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string OrganizationName { get; set; }
    }
}
