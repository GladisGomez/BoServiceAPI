﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ConceptosEdset
    {
        public int Id { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public string NoIdentificacion { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Importe { get; set; }
        public string ClaveProdServVer33 { get; set; }
        public string ClaveUnidadVer33 { get; set; }
        public decimal Descuento { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int EdcomplementoConceptosEd { get; set; }

        public virtual EdcomplementoSet EdcomplementoConceptosEdNavigation { get; set; }
    }
}
