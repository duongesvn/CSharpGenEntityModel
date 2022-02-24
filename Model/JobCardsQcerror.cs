using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class JobCardsQcerror
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public Guid? JobCardsQcguid { get; set; }
        public decimal? Quantity { get; set; }
        public string ScrapReasonId { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string JobCardId { get; set; }
        public string ShiftId { get; set; }

        public virtual JobCard JobCard { get; set; }
        public virtual JobCardsQc JobCardsQcgu { get; set; }
        public virtual ScrapReason ScrapReason { get; set; }
    }
}
