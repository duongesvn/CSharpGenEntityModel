using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleItemWaitingQuotation
    {
        public SaleItemWaitingQuotation()
        {
            SaleBomcategories = new HashSet<SaleBomcategory>();
        }

        public Guid OrganizationGuid { get; set; }
        public string ItemId { get; set; }
        public string ItemIdso { get; set; }
        public string ParentId { get; set; }
        public string ItemName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? SortOrder { get; set; }
        public Guid? RowGuid { get; set; }
        public string Solution { get; set; }
        public string High { get; set; }
        public string Package { get; set; }
        public string Volumn { get; set; }
        public string Lenght { get; set; }
        public string Weight { get; set; }
        public string Wide { get; set; }
        public string Transport { get; set; }
        public decimal? Quantity { get; set; }

        public virtual ICollection<SaleBomcategory> SaleBomcategories { get; set; }
    }
}
