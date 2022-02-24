using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ConsumableMaterial
    {
        public Guid ConsumableMaterialGuid { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string UnitMeasureId { get; set; }
        public string UnitMeasureName { get; set; }
        public bool? IsActive { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? OrganizationGuid { get; set; }
    }
}
