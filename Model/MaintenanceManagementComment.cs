using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceManagementComment
    {
        public Guid CommentGuid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid RecordGuid { get; set; }
        public Guid OrganizationGuid { get; set; }
        public string Comment { get; set; }
        public Guid EmployeeGuid { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string LoginName { get; set; }
        public Guid? DepartmentGuid { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
