using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class Device
    {
        public Guid RowGuid { get; set; }
        public int Id { get; set; }
        public string AssetId { get; set; }
        public string AssetName { get; set; }
        public string DeviceId { get; set; }
        public string Serial { get; set; }
        public string Company { get; set; }
        public string Power { get; set; }
        public int? Year { get; set; }
        public DateTime? ReceptionDay { get; set; }
        public int? FrequencyYear { get; set; }
        public DateTime? ExpiryMechanicalDate { get; set; }
        public DateTime? ExpiryElectricDate { get; set; }
        public int? DepreciationMonth { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public byte[] Thumb { get; set; }
        public string ImagePath { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string OrganizationName { get; set; }
    }
}
