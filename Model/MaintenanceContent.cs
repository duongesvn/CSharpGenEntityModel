using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceContent
    {
        public Guid RowGuid { get; set; }
        public string ContentMain { get; set; }
        public decimal? Times { get; set; }
        public string Note { get; set; }
        public string CriteriaTitle { get; set; }
        public string Method { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public Guid? OrganizationGuid { get; set; }
    }
}
