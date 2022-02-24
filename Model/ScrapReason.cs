using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            JobCards = new HashSet<JobCard>();
            JobCardsPqcs = new HashSet<JobCardsPqc>();
            JobCardsQcerrors = new HashSet<JobCardsQcerror>();
        }

        public Guid OrganizationGuid { get; set; }
        public string ScrapReasonId { get; set; }
        public string Title { get; set; }
        public int? SortOrder { get; set; }
        public string Type { get; set; }
        public bool? IsDefaultValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? ScrapReasonGuid { get; set; }

        public virtual ICollection<JobCard> JobCards { get; set; }
        public virtual ICollection<JobCardsPqc> JobCardsPqcs { get; set; }
        public virtual ICollection<JobCardsQcerror> JobCardsQcerrors { get; set; }
    }
}
