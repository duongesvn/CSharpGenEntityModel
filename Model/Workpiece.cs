using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class Workpiece
    {
        public Guid OrganizationGuid { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal ApecificGravity { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
