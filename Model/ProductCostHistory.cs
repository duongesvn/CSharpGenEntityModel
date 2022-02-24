using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ProductCostHistory
    {
        public Guid OrganizationGuid { get; set; }
        public string OrderNumber { get; set; }
        public string OrderPlanId { get; set; }
        public string InternalOrderNo { get; set; }
        public string ProductItemId { get; set; }
        public string PartItemId { get; set; }
        public DateTime Date { get; set; }
        public string CostType { get; set; }
        public string LocationId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountSurplus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? RowGuid { get; set; }
    }
}
