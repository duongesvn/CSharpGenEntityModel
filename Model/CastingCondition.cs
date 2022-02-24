using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class CastingCondition
    {
        public CastingCondition()
        {
            CastingConditionsHistories = new HashSet<CastingConditionsHistory>();
        }

        public Guid RowGuid { get; set; }
        public Guid OrganizationGuid { get; set; }
        public string MachineId { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public Guid? ItemGuid { get; set; }
        public string MaterialItemId { get; set; }
        public decimal? MixedRateZin { get; set; }
        public decimal? MixedRatePhe { get; set; }
        public decimal? WaterTemperatureDynamic { get; set; }
        public decimal? WaterTemperatureStill { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? Height { get; set; }
        public decimal? Wide { get; set; }
        public decimal? Thick { get; set; }
        public decimal? DryingTemperature { get; set; }
        public decimal? DryingTime { get; set; }
        public decimal? MachineTime { get; set; }
        public decimal? ProdcutionTime { get; set; }
        public decimal? Total { get; set; }
        public int? NumberEmployee { get; set; }
        public DateTime? Date { get; set; }
        public int? Version { get; set; }
        public string Qcby { get; set; }
        public int? Qcstatus { get; set; }
        public DateTime? Qcdate { get; set; }
        public string ApprovedBy { get; set; }
        public int? ApprovedStatus { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string MachineName { get; set; }
        public string Status { get; set; }
        public Guid? WorkFlowGuid { get; set; }
        public string WorkFlowsContent { get; set; }
        public Guid? WorkFlowCurrent { get; set; }
        public bool? IsLocked { get; set; }
        public string ConditionValue { get; set; }
        public Guid? EmployeeGuid { get; set; }
        public bool? IsChecked { get; set; }

        public virtual ICollection<CastingConditionsHistory> CastingConditionsHistories { get; set; }
    }
}
