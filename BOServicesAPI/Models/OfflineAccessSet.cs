﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class OfflineAccessSet
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public double? DateTimeLapse { get; set; }
        public int NumberItemSync { get; set; }
        public string LocationSync { get; set; }
        public string DataSync { get; set; }
        public string ErrorDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? OfflineAccessEmployee { get; set; }
        public int? OfflineSyncStatusOfflineAccess { get; set; }

        public virtual Employees OfflineAccessEmployeeNavigation { get; set; }
        public virtual OfflineSyncStatusSet OfflineSyncStatusOfflineAccessNavigation { get; set; }
    }
}
