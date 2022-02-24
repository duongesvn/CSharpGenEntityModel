using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MachinesItem
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string MachineId { get; set; }
        public string ItemId { get; set; }
        public Guid? ItemGuid { get; set; }
        public string ItemName { get; set; }

        public virtual Machine Machine { get; set; }
    }
}
