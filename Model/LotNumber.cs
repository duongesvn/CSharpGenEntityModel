using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class LotNumber
    {
        public LotNumber()
        {
            JobCards = new HashSet<JobCard>();
            ProductSpecifications = new HashSet<ProductSpecification>();
        }

        public Guid OrganizationGuid { get; set; }
        public string LotNumber1 { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal OrderQty { get; set; }
        public decimal StockedQty { get; set; }
        public decimal ScrappedQty { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? RowGuid { get; set; }

        public virtual ICollection<JobCard> JobCards { get; set; }
        public virtual ICollection<ProductSpecification> ProductSpecifications { get; set; }
    }
}
