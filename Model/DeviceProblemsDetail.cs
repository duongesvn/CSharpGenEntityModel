using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class DeviceProblemsDetail
    {
        public Guid RowGuid { get; set; }
        public Guid? DeviceProblemId { get; set; }
        public string MaterialCode { get; set; }
        public int? Quantity { get; set; }
        public string UnitMeasureId { get; set; }
        public decimal? RepairCosts { get; set; }
        public decimal? OutsourcingCosts { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual DeviceProblem DeviceProblem { get; set; }
    }
}
