using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class BomcategoriesTechnical
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string Title1 { get; set; }
        public string Value1 { get; set; }
        public string Title2 { get; set; }
        public string Value2 { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? SortOrder { get; set; }

        public virtual Bomcategory Bomcategory { get; set; }
    }
}
