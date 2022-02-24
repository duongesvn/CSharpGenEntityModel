using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class CostNormsByLocation
    {
        public Guid OrganizationGuid { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public int StartDate { get; set; }
        public string CostType { get; set; }
        public string CostId { get; set; }
        public string CostName { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Location Location { get; set; }
    }
}
