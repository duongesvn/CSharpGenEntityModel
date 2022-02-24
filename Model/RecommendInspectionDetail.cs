using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class RecommendInspectionDetail
    {
        public Guid RowGuid { get; set; }
        public Guid? RecordGuid { get; set; }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Unit { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
