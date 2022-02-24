using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class JobCardsQc
    {
        public JobCardsQc()
        {
            JobCardsQcerrors = new HashSet<JobCardsQcerror>();
        }

        public Guid? OrganizationGuid { get; set; }
        public Guid RowGuid { get; set; }
        public string Number { get; set; }
        public int? DateInt { get; set; }
        public int? RunNumber { get; set; }
        public Guid? TicketDetailGuid { get; set; }
        public string TicketNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public string OrderNumber { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityOk { get; set; }
        public decimal? QuantityNg { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string SupportorId { get; set; }
        public string SupportorName { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CheckById { get; set; }
        public string CheckByName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<JobCardsQcerror> JobCardsQcerrors { get; set; }
    }
}
