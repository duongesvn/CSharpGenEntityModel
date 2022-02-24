using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class RecommendInspection
    {
        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string Code { get; set; }
        public Guid? EmployeeGuid { get; set; }
        public string EmployeeName { get; set; }
        public Guid? DepartmentGuid { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? SuggestedDate { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public string ConditionValue { get; set; }
        public Guid? WorkFlowGuid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
