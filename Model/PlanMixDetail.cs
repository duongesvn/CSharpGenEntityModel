using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class PlanMixDetail
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string PlanMixCode { get; set; }
        public string PartItemId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public Guid? UnitGuid { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Percent { get; set; }
        public decimal? QuantityNet { get; set; }
        public decimal? PercentNg { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PlanMix PlanMix { get; set; }
    }
}
