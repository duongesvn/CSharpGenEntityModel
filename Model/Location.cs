using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class Location
    {
        public Location()
        {
            BomworkOrderRoutings = new HashSet<BomworkOrderRouting>();
            CostNormsByLocations = new HashSet<CostNormsByLocation>();
            InverseLocationNavigation = new HashSet<Location>();
            JobCards = new HashSet<JobCard>();
            Machines = new HashSet<Machine>();
        }

        public Guid OrganizationGuid { get; set; }
        public string LocationId { get; set; }
        public string Title { get; set; }
        public string LocationGroupId { get; set; }
        public string Description { get; set; }
        public string PreLoactionId { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsProgram { get; set; }
        public bool? IsBillet { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefaultValue { get; set; }
        public Guid? LocationGuid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ParentId { get; set; }

        public virtual LocationGroup LocationGroup { get; set; }
        public virtual Location LocationNavigation { get; set; }
        public virtual ICollection<BomworkOrderRouting> BomworkOrderRoutings { get; set; }
        public virtual ICollection<CostNormsByLocation> CostNormsByLocations { get; set; }
        public virtual ICollection<Location> InverseLocationNavigation { get; set; }
        public virtual ICollection<JobCard> JobCards { get; set; }
        public virtual ICollection<Machine> Machines { get; set; }
    }
}
