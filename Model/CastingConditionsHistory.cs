using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class CastingConditionsHistory
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string MachineId { get; set; }
        public string ItemId { get; set; }
        public string Body { get; set; }
        public DateTime? Date { get; set; }
        public int? Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid RecordGuid { get; set; }

        public virtual CastingCondition CastingCondition { get; set; }
    }
}
