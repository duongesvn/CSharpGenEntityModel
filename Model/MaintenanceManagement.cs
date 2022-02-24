using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceManagement
    {
        public MaintenanceManagement()
        {
            MaintenanceManagementDetails = new HashSet<MaintenanceManagementDetail>();
        }

        public Guid MaintainGuid { get; set; }
        public string MaintainNumber { get; set; }
        public string ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string OrderNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Serial { get; set; }
        public string Barcode { get; set; }
        public string DeliveryNumber { get; set; }
        public int? TotalTimes { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? NextDate { get; set; }
        public byte? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsLocked { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public int? WarrantyTicketsDetailId { get; set; }
        public int? ConfirmStatus { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? FrequencyYear { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string OrganizationName { get; set; }
        public string PlanType { get; set; }
        public string MachineTypeId { get; set; }

        public virtual ICollection<MaintenanceManagementDetail> MaintenanceManagementDetails { get; set; }
    }
}
