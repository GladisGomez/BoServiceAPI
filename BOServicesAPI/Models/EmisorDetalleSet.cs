using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class EmisorDetalleSet
    {
        public int Id { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string RegimenFiscalVer33 { get; set; }
        public string DomicilioFiscalCalle { get; set; }
        public string DomicilioFiscalNoExterior { get; set; }
        public string DomicilioFiscalNoInterior { get; set; }
        public string DomicilioFiscalColonia { get; set; }
        public string DomicilioFiscalMunicipio { get; set; }
        public string DomicilioFiscalEstado { get; set; }
        public string DomicilioFiscalPais { get; set; }
        public string DomicilioFiscalCodigoPostal { get; set; }
        public string ExpedidoCalle { get; set; }
        public string ExpedidoNoExterior { get; set; }
        public string ExpedidoNoInterior { get; set; }
        public string ExpedidoColonia { get; set; }
        public string ExpedidoMunicipio { get; set; }
        public string ExpedidoEstado { get; set; }
        public string ExpedidoPais { get; set; }
        public string ExpedidoCodigoPostal { get; set; }
        public string RegimenFiscal { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
