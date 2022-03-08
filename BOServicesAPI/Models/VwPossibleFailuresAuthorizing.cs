using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPossibleFailuresAuthorizing
    {
        public long? Numref { get; set; }
        public string Tag { get; set; }
        public int? Codcli { get; set; }
        public string Den { get; set; }
        public string Plc { get; set; }
        public string Nroeco { get; set; }
        public string Expr1 { get; set; }
        public int? NroVeh { get; set; }
        public string Tipo { get; set; }
        public string Cveest { get; set; }
        public int? Codgas { get; set; }
        public string Abr { get; set; }
        public string Expr2 { get; set; }
        public long? NumDeDesp { get; set; }
        public DateTime? FchEstacion { get; set; }
        public DateTime? Fchserver { get; set; }
        public int? UltOdm { get; set; }
        public int? NewOdm { get; set; }
        public string AcuTur { get; set; }
        public string Ultcar { get; set; }
        public string Ulttur { get; set; }
        public string Est { get; set; }
        public int? EstVehOri { get; set; }
        public int? EstVehNew { get; set; }
        public DateTime? FchLog { get; set; }
    }
}
