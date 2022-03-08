using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwReporteEstaciones
    {
        public int Id { get; set; }
        public string NumeroEstacion { get; set; }
        public string NombreOficial { get; set; }
        public string NickName { get; set; }
        public bool Estatus { get; set; }
        public bool Magna { get; set; }
        public bool Premium { get; set; }
        public bool Diesel { get; set; }
        public string Volumetrico { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Colony { get; set; }
        public string City { get; set; }
        public string Cpaddres { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Cp { get; set; }
        public string NoInterior { get; set; }
        public string NoExterior { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public string RepresentanteLegal { get; set; }
        public bool? PersonaMoral { get; set; }
        public bool? PersonaFisica { get; set; }
        public string Curp { get; set; }
        public bool? EnAutomatico { get; set; }
        public DateTime? FechaInicio { get; set; }
        public int? Periodicidad { get; set; }
        public decimal? PorcentajeComision { get; set; }
        public string Mail { get; set; }
        public string OficialNameEstacionGrupo { get; set; }
        public string NickNameEstacionGrupo { get; set; }
        public string NombreContacto { get; set; }
        public string MailContacto { get; set; }
        public string CelularContacto { get; set; }
    }
}
