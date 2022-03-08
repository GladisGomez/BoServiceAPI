using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPerfilParametroPorCliente
    {
        public int Id { get; set; }
        public int IdParametro { get; set; }
        public string Nombre { get; set; }
        public string Comentarios { get; set; }
        public string CreadoPor { get; set; }
        public DateTimeOffset? Fecha { get; set; }
    }
}
