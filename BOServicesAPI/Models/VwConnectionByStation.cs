using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwConnectionByStation
    {
        public string Contacto { get; set; }
        public DateTime InicioDeConexion { get; set; }
        public DateTime FinDeConexion { get; set; }
        public string Comentarios { get; set; }
        public string Empleado { get; set; }
        public string ActividadesEnLaEstacion { get; set; }
        public string Estacion { get; set; }
        public int IdEmpleado { get; set; }
        public int IdActividad { get; set; }
        public int IdEstacion { get; set; }
        public string NumeroEstacion { get; set; }
    }
}
