﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class UsersInClientGroupSet
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? UsersInClientGroupClientGroup { get; set; }
        public int? UsersInClientGroupGasStationGroup { get; set; }
        public int UsersInClientGroupUserWeb { get; set; }

        public virtual ClientGroups UsersInClientGroupClientGroupNavigation { get; set; }
        public virtual GasStationGroups UsersInClientGroupGasStationGroupNavigation { get; set; }
        public virtual UserWebSet UsersInClientGroupUserWebNavigation { get; set; }
    }
}