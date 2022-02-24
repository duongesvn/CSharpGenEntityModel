using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleBomcamSheetSetting
    {
        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public string LocationId { get; set; }
        public string CamSheetId { get; set; }
        public string KnifeId { get; set; }
        public decimal? Phi { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? StepProcess { get; set; }
        public decimal? Speed { get; set; }
        public decimal? Depth { get; set; }
        public decimal? MachineTime { get; set; }
        public decimal? SetupTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? RowGuid { get; set; }
        public Guid? CamSheetGuid { get; set; }

        public virtual SaleBomcamSheet SaleBomcamSheet { get; set; }
    }
}
