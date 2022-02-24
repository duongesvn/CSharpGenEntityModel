using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleBomworkOrderRouting
    {
        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public string LocationId { get; set; }
        public string GroupLocationId { get; set; }
        public decimal? ProductionTime { get; set; }
        public decimal? SetupTime { get; set; }
        public string MachineId { get; set; }
        public string FixtureId { get; set; }
        public string CuttingToolId { get; set; }
        public string MeasuringToolId { get; set; }
        public int? NumberTask { get; set; }
        public int? SortOrder { get; set; }
        public string Type { get; set; }
        public decimal? LaborCost { get; set; }
        public decimal? InsuranceCost { get; set; }
        public decimal? MachineCost { get; set; }
        public decimal? ElectricityCost { get; set; }
        public decimal? FactoryCost { get; set; }
        public decimal? FixtureCost { get; set; }
        public decimal? CuttingCost { get; set; }
        public decimal? MeasuringCost { get; set; }
        public decimal? AuxiliaryMaterialCost { get; set; }
        public decimal? TotalCost { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? RowGuid { get; set; }

        public virtual SaleBomcategory SaleBomcategory { get; set; }
    }
}
