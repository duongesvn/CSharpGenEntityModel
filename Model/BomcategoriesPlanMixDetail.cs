using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class BomcategoriesPlanMixDetail
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string PlanMixCode { get; set; }
        public string PlanMixName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Amount { get; set; }
        public string Note { get; set; }
        public string PartItemId { get; set; }
        public string ShiftId { get; set; }
        public string ShiftName { get; set; }
        public bool? IsActive { get; set; }
        public string Type { get; set; }
        public Guid? BomcategoriesPlanMixsGuid { get; set; }
        public string Bomnumber { get; set; }

        public virtual BomcategoriesPlanMix BomcategoriesPlanMixsGu { get; set; }
    }
}
