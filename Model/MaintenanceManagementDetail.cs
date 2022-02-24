using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceManagementDetail
    {
        public Guid MaintainDetailGuid { get; set; }
        public Guid? MaintainGuid { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? MaintainTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte? Times { get; set; }
        public string Result { get; set; }
        public string Body { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsConfirm { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? ConfirmDateTo { get; set; }
        public DateTime? ConfirmDateFrom { get; set; }
        public DateTime? ActualDateFrom { get; set; }
        public DateTime? ActualDateTo { get; set; }
        public Guid? MaintenanceRequestId { get; set; }

        public virtual MaintenanceManagement MaintainGu { get; set; }
    }
}
