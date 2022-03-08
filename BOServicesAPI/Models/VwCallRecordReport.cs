using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwCallRecordReport
    {
        public string Operador { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Telefono { get; set; }
        public string Estación { get; set; }
        public string NickNameEstacion { get; set; }
        public string Cliente { get; set; }
        public string NickNameCliente { get; set; }
        public string Grupo { get; set; }
        public string Placa { get; set; }
        public string Económico { get; set; }
        public string NombrePersona { get; set; }
        public string Rol { get; set; }
        public string Problema { get; set; }
        public string Folio { get; set; }
        public string Estatus { get; set; }
        public string Departamento { get; set; }
        public string Comentarios { get; set; }
        public int IdEmpleado { get; set; }
        public int IdEstatus { get; set; }
        public int? IdClienteGrupo { get; set; }
        public int? IdCliente { get; set; }
        public int IdDepartamento { get; set; }
        public int? IdEstacion { get; set; }
        public int IdTipoLlamada { get; set; }
        public int? IdVehiculo { get; set; }
    }
}
