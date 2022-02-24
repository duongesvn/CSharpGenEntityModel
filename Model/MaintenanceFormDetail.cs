using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceFormDetail
    {
        public Guid RowGuid { get; set; }
        public Guid? MaintenanceFormId { get; set; }
        public Guid? MaintenanceContentId { get; set; }
        public decimal? Times { get; set; }
        public string Note { get; set; }
        public string Results { get; set; }
        public string MaterialCode { get; set; }
        public int? Quantity { get; set; }
        public string UnitMeasureId { get; set; }
        public string CriteriaTitle { get; set; }
        public string Method { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SortOrder { get; set; }
    }
}
