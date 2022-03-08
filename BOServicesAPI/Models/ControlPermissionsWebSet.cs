﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ControlPermissionsWebSet
    {
        public int Id { get; set; }
        public bool Access { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ControlPermissionsWebControlsWeb { get; set; }
        public int ControlPermissionsWebPermissionsWeb1 { get; set; }

        public virtual ControlsWebSet ControlPermissionsWebControlsWebNavigation { get; set; }
        public virtual PermissionsWebSet ControlPermissionsWebPermissionsWeb1Navigation { get; set; }
    }
}
