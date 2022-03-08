using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionConnection
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsInternetOk { get; set; }
        public bool? RemoteControlPossible { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportMalfunctionConnection { get; set; }

        public virtual MalfunctionReport MalfunctionReportMalfunctionConnectionNavigation { get; set; }
    }
}
