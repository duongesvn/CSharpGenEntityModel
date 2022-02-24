﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class MachineType
    {
        public MachineType()
        {
            Machines = new HashSet<Machine>();
        }

        public Guid OrganizationGuid { get; set; }
        public string MachineTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefaultValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid? MachineTypeGuid { get; set; }

        public virtual ICollection<Machine> Machines { get; set; }
    }
}
