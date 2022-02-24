using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class BomcategoriesPlanMix
    {
        public BomcategoriesPlanMix()
        {
            BomcategoriesPlanMixDetails = new HashSet<BomcategoriesPlanMixDetail>();
            Bomworkpieces = new HashSet<Bomworkpiece>();
        }

        public Guid RowGuid { get; set; }
        public Guid? OrganizationGuid { get; set; }
        public string Bomnumber { get; set; }
        public string PlanMixCode { get; set; }
        public string PlanMixName { get; set; }
        public string PartItemId { get; set; }
        public decimal? Quantity { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Bomcategory Bomcategory { get; set; }
        public virtual PlanMix PlanMix { get; set; }
        public virtual ICollection<BomcategoriesPlanMixDetail> BomcategoriesPlanMixDetails { get; set; }
        public virtual ICollection<Bomworkpiece> Bomworkpieces { get; set; }
    }
}
