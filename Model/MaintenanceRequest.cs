using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceRequest
    {
        public MaintenanceRequest()
        {
            MaintenanceRequestDetails = new HashSet<MaintenanceRequestDetail>();
        }

        public Guid RowGuid { get; set; }
        public string MaintenanceRequestId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public int? Year { get; set; }
        public DateTime? ReceptionDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ActualTime { get; set; }
        public int? PlanTime { get; set; }
        public string Note { get; set; }
        public string EmployeeId { get; set; }
        public string MaintainNumber { get; set; }
        public int? Approve { get; set; }
        public int? ApproveStatus { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string OrganizationName { get; set; }
        public string MachineTypeId { get; set; }
        public DateTime? ActualDate { get; set; }
        public string PlanType { get; set; }

        public virtual ICollection<MaintenanceRequestDetail> MaintenanceRequestDetails { get; set; }
    }
}
