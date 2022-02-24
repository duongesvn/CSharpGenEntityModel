using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class OriginWorkpiece
    {
        public Guid OrganizationGuid { get; set; }
        public string OriginId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsDefaultValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? RowGuid { get; set; }
        public string ImageUrl { get; set; }
    }
}
