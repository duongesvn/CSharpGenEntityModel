using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class LocationGroup
    {
        public LocationGroup()
        {
            InverseLocationGroupNavigation = new HashSet<LocationGroup>();
            Locations = new HashSet<Location>();
        }

        public Guid OrganizationGuid { get; set; }
        public string LocationGroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public bool? IsActive { get; set; }
        public string FieldTypeId { get; set; }
        public string GroupParentId { get; set; }
        public Guid? LocationGroupGuid { get; set; }
        public bool? IsDefaultValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual FieldType FieldType { get; set; }
        public virtual LocationGroup LocationGroupNavigation { get; set; }
        public virtual ICollection<LocationGroup> InverseLocationGroupNavigation { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
