using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TimbreFiscalSet
    {
        public TimbreFiscalSet()
        {
            Edcset = new HashSet<Edcset>();
            Edeset = new HashSet<Edeset>();
        }

        public int Id { get; set; }
        public string Uuid { get; set; }
        public DateTime FechaTimbrado { get; set; }
        public string NoCertificadoSat { get; set; }
        public string SelloSat { get; set; }
        public string SelloCfd { get; set; }
        public string Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Edcset> Edcset { get; set; }
        public virtual ICollection<Edeset> Edeset { get; set; }
    }
}
