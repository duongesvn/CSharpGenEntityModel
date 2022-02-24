using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MaintenanceManagementAttachment
    {
        public Guid Rowguid { get; set; }
        public Guid? MaintainGuid { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string FileNameRoot { get; set; }
        public string FileExtension { get; set; }
        public string ExternalUrl { get; set; }
        public string Summary { get; set; }
        public byte[] Attachment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMaintainDetail { get; set; }
        public int? MaintainDetailId { get; set; }
    }
}
