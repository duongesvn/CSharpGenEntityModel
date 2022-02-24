using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MachineError
    {
        public Guid OrganizationGuid { get; set; }
        public Guid RowGuid { get; set; }
        public string MachineId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public bool? IsDefaultValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Machine Machine { get; set; }
    }
}
