using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class FieldType
    {
        public FieldType()
        {
            LocationGroups = new HashSet<LocationGroup>();
        }

        public Guid OrganizationGuid { get; set; }
        public string FieldTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefaultValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<LocationGroup> LocationGroups { get; set; }
    }
}
