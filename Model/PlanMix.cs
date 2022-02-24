using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class PlanMix
    {
        public PlanMix()
        {
            BomcategoriesPlanMixes = new HashSet<BomcategoriesPlanMix>();
            PlanMixDetails = new HashSet<PlanMixDetail>();
        }

        public Guid? RowGuid { get; set; }
        public Guid OrganizationGuid { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public decimal? Cost { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string GroupItemId { get; set; }

        public virtual ICollection<BomcategoriesPlanMix> BomcategoriesPlanMixes { get; set; }
        public virtual ICollection<PlanMixDetail> PlanMixDetails { get; set; }
    }
}
