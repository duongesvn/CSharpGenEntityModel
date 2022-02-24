using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ProductionPlanDayHeader
    {
        public ProductionPlanDayHeader()
        {
            ProductionPlanDays = new HashSet<ProductionPlanDay>();
        }

        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string Title { get; set; }
        public string OrderPlanId { get; set; }
        public DateTime? PlanDate { get; set; }
        public int? PlanDateInt { get; set; }
        public string Status { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Guid? EmployeeGuid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<ProductionPlanDay> ProductionPlanDays { get; set; }
    }
}
