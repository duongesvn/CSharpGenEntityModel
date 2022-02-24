using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ProductSpecification
    {
        public Guid OrganizationGuid { get; set; }
        public string LotNumber { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string AttributeId { get; set; }
        public int SortOrder { get; set; }
        public string AttributeName { get; set; }
        public string SelectedValue { get; set; }
        public string DisplayValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? RowGuid { get; set; }

        public virtual LotNumber LotNumberNavigation { get; set; }
    }
}
