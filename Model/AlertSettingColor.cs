using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class AlertSettingColor
    {
        public Guid OrganizationGuid { get; set; }
        public string Alias { get; set; }
        public string StatusId { get; set; }
        public string FontColor { get; set; }
        public string BackgroundColor { get; set; }
        public bool? IsBoldFont { get; set; }
        public bool? IsItalicFont { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? RowGuid { get; set; }
    }
}
