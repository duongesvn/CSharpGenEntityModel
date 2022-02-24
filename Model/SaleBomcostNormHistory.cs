using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class SaleBomcostNormHistory
    {
        public Guid OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string ProductItemId { get; set; }
        public DateTime Date { get; set; }
        public string CostType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountSurplus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? RowGuid { get; set; }

        public virtual SaleBomcategory SaleBomcategory { get; set; }
    }
}
