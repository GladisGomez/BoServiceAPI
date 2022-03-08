using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionAntenna
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? NotImpossibleToCheck { get; set; }
        public bool? PingWorks { get; set; }
        public bool? ElectricCableConnected { get; set; }
        public bool? EthernetCableConnected { get; set; }
        public bool? IpConfigCorrect { get; set; }
        public bool? IsSgpsHasTheRightForecourtIp { get; set; }
        public bool? IsAviManagerServiceOk { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionAntennaAntenna { get; set; }
        public int MalfunctionReportMalfunctionAntenna { get; set; }

        public virtual Antenna MalfunctionAntennaAntennaNavigation { get; set; }
        public virtual MalfunctionReport MalfunctionReportMalfunctionAntennaNavigation { get; set; }
    }
}
