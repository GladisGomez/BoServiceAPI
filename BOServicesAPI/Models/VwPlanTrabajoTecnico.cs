using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPlanTrabajoTecnico
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
