using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class RecommendInspectionProcess
    {
        public Guid RowGuid { get; set; }
        public Guid RecordGuid { get; set; }
        public Guid EmployeeGuid { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string JobTitleName { get; set; }
        public string LoginName { get; set; }
        public Guid OrganizationGuid { get; set; }
        public Guid DepartmentGuid { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string ActionName { get; set; }
        public string Comment { get; set; }
        public Guid? WorkFlowCurrent { get; set; }
        public string WfstatusId { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
