using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceRequestDetail
    {
        public Guid RowGuid { get; set; }
        public Guid? MaintenanceRequestId { get; set; }
        public Guid? MaintenanceContentId { get; set; }
        public int? Times { get; set; }
        public string Note { get; set; }
        public string Results { get; set; }
        public string MaterialCode { get; set; }
        public int? Quantity { get; set; }
        public string UnitMeasureId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalMoney { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Phenomena { get; set; }
        public string JobDetails { get; set; }
        public string CriteriaTitle { get; set; }
        public string MethodType { get; set; }
        public string Evaluate { get; set; }

        public virtual MaintenanceRequest MaintenanceRequest { get; set; }
    }
}
