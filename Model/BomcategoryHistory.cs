using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class BomcategoryHistory
    {
        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid RowGuid { get; set; }

        public virtual Bomcategory Bomcategory { get; set; }
    }
}
