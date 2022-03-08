using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DispatchHistorySet
    {
        public int Id { get; set; }
        public int? Nro { get; set; }
        public int? Nrobom { get; set; }
        public int? CodCli { get; set; }
        public string Cli { get; set; }
        public string Den { get; set; }
        public int? CodGas { get; set; }
        public string Gas { get; set; }
        public string Grp { get; set; }
        public string Sbg { get; set; }
        public DateTime? Fch { get; set; }
        public int? CodProd { get; set; }
        public string Prd { get; set; }
        public double? Can { get; set; }
        public double? Mto { get; set; }
        public string Rut { get; set; }
        public int? Veh { get; set; }
        public string Plc { get; set; }
        public int? Tar { get; set; }
        public string Rsp { get; set; }
        public int? Odm { get; set; }
        public int? Est { get; set; }
        public int? IdClientGroupBo { get; set; }
        public int? ClientGroupBo { get; set; }
        public string Nroeco { get; set; }
        public double? Pre { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
