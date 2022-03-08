using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryProductMovementsSet
    {
        public int Id { get; set; }
        public string CodProd { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Unidad { get; set; }
        public string Status { get; set; }
        public string AccesoriesCollection { get; set; }
        public string Tags { get; set; }
        public string Meters { get; set; }
        public string GpsCollection { get; set; }
        public string Antennas { get; set; }
        public string Readers { get; set; }
        public string BatteryCollection { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
