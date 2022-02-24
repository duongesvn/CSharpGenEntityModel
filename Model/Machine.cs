using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class Machine
    {
        public Machine()
        {
            JobCards = new HashSet<JobCard>();
            MachineErrors = new HashSet<MachineError>();
            MachinesItems = new HashSet<MachinesItem>();
            PlanResources = new HashSet<PlanResource>();
        }

        public Guid OrganizationGuid { get; set; }
        public string MachineId { get; set; }
        public string Title { get; set; }
        public string MachineTypeId { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }
        public int? ManufacturingYear { get; set; }
        public string MadeIn { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
        public string LocationGroupId { get; set; }
        public string LocationId { get; set; }
        public string AssetCardId { get; set; }
        public Guid? ToolVoucherGuid { get; set; }
        public string ToolId { get; set; }
        public Guid MachineGuid { get; set; }
        public bool? IsDefaultValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ShiftId { get; set; }
        public decimal? ProductionTime { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? Numberbroken { get; set; }
        public string Serial { get; set; }
        public DateTime? ReceptionDay { get; set; }
        public int? FrequencyYear { get; set; }
        public DateTime? ExpiryMechanicalDate { get; set; }
        public DateTime? ExpiryElectricDate { get; set; }
        public int? DepreciationMonth { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public bool? IsActive { get; set; }
        public byte[] Thumb { get; set; }
        public string AssetId { get; set; }
        public int? SortOrder { get; set; }
        public string Size { get; set; }
        public string ProductSide { get; set; }
        public int? Number { get; set; }
        public int? Quantity { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public DateTime? StartDate { get; set; }
        public string Note { get; set; }
        public decimal? ClampingForce { get; set; }
        public string AutoClamping { get; set; }
        public string Manual { get; set; }
        public string ThicknessMold { get; set; }
        public string Hydraulic { get; set; }
        public decimal? Screw { get; set; }
        public decimal? Max { get; set; }
        public decimal? ShotWeight { get; set; }
        public decimal? InjectionPressure { get; set; }
        public decimal? InjectionRate { get; set; }
        public decimal? InjectionSpeed { get; set; }
        public decimal? ScrewSpeed { get; set; }
        public decimal? HorizontalTie { get; set; }
        public decimal? VerticalTie { get; set; }
        public decimal? HorizontalPlaten { get; set; }
        public decimal? VerticalPlaten { get; set; }
        public decimal? MinClampingStrock { get; set; }
        public decimal? MaxClampingStrock { get; set; }
        public decimal? EjectorStroke { get; set; }
        public decimal? AutoClampingPlate { get; set; }
        public decimal? LocatingRingDia { get; set; }
        public string UtilizedOilQuantity { get; set; }
        public decimal? ElectricMotor { get; set; }
        public decimal? ElectricHeater { get; set; }
        public string Maker { get; set; }
        public string Stroke { get; set; }
        public string HeatingType { get; set; }
        public string MainVoltage { get; set; }
        public string TemperatureController { get; set; }
        public string Chiller { get; set; }
        public string EmployeeIdShift1 { get; set; }
        public string EmployeeNameShift1 { get; set; }
        public Guid? EmployeeGuidShift1 { get; set; }
        public string EmployeeIdShift3 { get; set; }
        public string EmployeeNameShift3 { get; set; }
        public Guid? EmployeeGuidShift3 { get; set; }
        public string ItemId { get; set; }
        public Guid? ItemGuid { get; set; }
        public string ItemName { get; set; }
        public string ModelName { get; set; }
        public string Plasticizingcapacity { get; set; }
        public string ManualClampingPlate { get; set; }
        public string MinMold { get; set; }
        public string MaxMold { get; set; }
        public string Diameterhole { get; set; }
        public string Cheapendpoint { get; set; }
        public string Coupler { get; set; }
        public string FixPlate { get; set; }
        public string MoveablePlate { get; set; }
        public string NoofZone { get; set; }
        public string NormalWaterAbility { get; set; }
        public decimal? StandardShotNumber { get; set; }
        public string RobotModelName { get; set; }
        public string TieCrusher { get; set; }
        public decimal? TimeStandard { get; set; }
        public Guid? ShiftLeadGuid1 { get; set; }
        public Guid? ShiftLeadGuid3 { get; set; }
        public string ShiftLeadName1 { get; set; }
        public string ShiftLeadName3 { get; set; }

        public virtual Location Location { get; set; }
        public virtual MachineType MachineType { get; set; }
        public virtual ICollection<JobCard> JobCards { get; set; }
        public virtual ICollection<MachineError> MachineErrors { get; set; }
        public virtual ICollection<MachinesItem> MachinesItems { get; set; }
        public virtual ICollection<PlanResource> PlanResources { get; set; }
    }
}
