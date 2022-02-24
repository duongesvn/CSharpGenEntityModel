using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceForm
    {
        public Guid RowGuid { get; set; }
        public string MaintenanceFormId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string OrganizationName { get; set; }
    }
}
