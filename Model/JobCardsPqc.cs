using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class JobCardsPqc
    {
        public Guid OrganizationGuid { get; set; }
        public Guid RowGuid { get; set; }
        public string JobCardId { get; set; }
        public string Qrcode { get; set; }
        public string CheckBy { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? QuantityDelivered { get; set; }
        public decimal? QuantityQc { get; set; }
        public decimal? CheckQuantityOk { get; set; }
        public decimal? CheckQuantityNg { get; set; }
        public decimal? CheckQuantityCancel { get; set; }
        public string ScrapReasonId { get; set; }
        public string ReasonId { get; set; }
        public string Solutions { get; set; }
        public Guid? DepartmentGuid { get; set; }
        public string DepartmentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual JobCard JobCard { get; set; }
        public virtual ScrapReason ScrapReason { get; set; }
    }
}
