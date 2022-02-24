using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class PlanCostLabor
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string PlanMixCode { get; set; }
        public string PlanMixName { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string PartItemId { get; set; }
        public string PartItemName { get; set; }
        public string ShiftId { get; set; }
        public string ShiftName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Cost { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? AppliedDate { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
