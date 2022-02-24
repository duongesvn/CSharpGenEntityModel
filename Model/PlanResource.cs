using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class PlanResource
    {
        public Guid RowGuid { get; set; }
        public Guid OrganizationGuid { get; set; }
        public Guid PlanDayGuid { get; set; }
        public short? LocationId { get; set; }
        public string MarchineId { get; set; }
        public decimal? LaborCost { get; set; }
        public decimal? InsuranceCost { get; set; }
        public decimal? MachineCost { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal? QuantityNeed { get; set; }
        public decimal? QuantityRequired { get; set; }
        public decimal? Quantity { get; set; }
        public int? Time { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Machine Machine { get; set; }
        public virtual ProductionPlanDay PlanDayGu { get; set; }
    }
}
