using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class CheckMachineDaily
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string Code { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Title { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string MaintenanceFormId { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
