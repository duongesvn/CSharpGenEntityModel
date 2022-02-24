using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class DeviceProblemsCommentAttachment
    {
        public Guid AttachmentGuid { get; set; }
        public Guid? ParentGuid { get; set; }
        public Guid RecordGuid { get; set; }
        public Guid OrganizationGuid { get; set; }
        public Guid? DepartmentGuid { get; set; }
        public string ModuleId { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public byte[] Attachment { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public string UrlExternal { get; set; }
        public bool? IsPublic { get; set; }
        public string PrivateLevel { get; set; }
        public bool? IsFolder { get; set; }
        public bool? IsHidden { get; set; }
        public bool? IsReadonly { get; set; }
        public bool? IsSync { get; set; }
        public DateTime? SyncTime { get; set; }
        public string CloudPath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
