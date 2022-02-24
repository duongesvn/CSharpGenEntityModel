using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ProductCost
    {
        public Guid OrganizationGuid { get; set; }
        public string JobCardId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderPlanId { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public DateTime Date { get; set; }
        public string CostId { get; set; }
        public string CostType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? InsuranceCost { get; set; }
        public string FollowGuid { get; set; }
        public Guid RowGuid { get; set; }

        public virtual JobCard JobCard { get; set; }
    }
}
