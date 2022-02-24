using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class DeviceProblem
    {
        public DeviceProblem()
        {
            DeviceProblemsDetails = new HashSet<DeviceProblemsDetail>();
        }

        public Guid RowGuid { get; set; }
        public string DeviceProblemId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DateTime? DateProblem { get; set; }
        public DateTime? DateFinish { get; set; }
        public int? DateStop { get; set; }
        public string ProblemCurrent { get; set; }
        public string ProblemStatus { get; set; }
        public string EmployeeId { get; set; }
        public Guid? Classification { get; set; }
        public string Reason { get; set; }
        public string Remedies { get; set; }
        public string MaterialCode { get; set; }
        public int? Quantity { get; set; }
        public string UnitId { get; set; }
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
        public string OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string Priority { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string OrganizationName { get; set; }
        public string Countermeasures { get; set; }
        public string MachineTypeId { get; set; }
        public string ManagerId { get; set; }
        public int? ManagerApprove { get; set; }
        public string RepairType { get; set; }

        public virtual ICollection<DeviceProblemsDetail> DeviceProblemsDetails { get; set; }
    }
}
