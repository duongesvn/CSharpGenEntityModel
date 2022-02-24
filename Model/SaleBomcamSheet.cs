using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleBomcamSheet
    {
        public SaleBomcamSheet()
        {
            SaleBomcamSheetSettings = new HashSet<SaleBomcamSheetSetting>();
        }

        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public string LocationId { get; set; }
        public string CamSheetId { get; set; }
        public DateTime? CamSheetDate { get; set; }
        public decimal? WorkpieceQuantity { get; set; }
        public decimal? MachineTime { get; set; }
        public decimal? SetupTime { get; set; }
        public string OriginId { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string UrlImage { get; set; }
        public Guid? RowGuid { get; set; }
        public Guid? BoworGuid { get; set; }

        public virtual SaleBomcategory SaleBomcategory { get; set; }
        public virtual ICollection<SaleBomcamSheetSetting> SaleBomcamSheetSettings { get; set; }
    }
}
