using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ConciliationVinset
    {
        public int Id { get; set; }
        public int? IdTransaccion { get; set; }
        public string NumTransaction { get; set; }
        public string ValorVin { get; set; }
        public string ValorBo { get; set; }
        public string IdVin { get; set; }
        public int? IdBo { get; set; }
        public DateTime FechaConciliacion { get; set; }
        public int? IdEstacion { get; set; }
        public string NumEstacion { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
