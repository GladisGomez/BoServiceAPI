using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPlanTrabajoTecnicos
    {
        public int IdTecnico { get; set; }
        public string Tecnico { get; set; }
        public int NumeroCita { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaAproxCierre { get; set; }
        public int IdServicio { get; set; }
        public string Servicio { get; set; }
        public int IdPrioridad { get; set; }
        public string Prioridad { get; set; }
        public string Direccion { get; set; }
    }
}
