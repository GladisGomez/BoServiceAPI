using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ConfiguracionDescuentoEdset
    {
        public int Id { get; set; }
        public decimal Importe { get; set; }
        public decimal Descuento { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ConfiguracionDescuentoEdClientGroup { get; set; }
        public int? ConfDescuentoEdClientGroups { get; set; }
        public int? ConfDescuentoEdGasStations { get; set; }

        public virtual ClientGroups ConfiguracionDescuentoEdClientGroupNavigation { get; set; }
    }
}
