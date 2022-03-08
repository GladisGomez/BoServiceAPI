﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReceptorSet
    {
        public ReceptorSet()
        {
            CitySet = new HashSet<CitySet>();
            Edcset = new HashSet<Edcset>();
            Edeset = new HashSet<Edeset>();
        }

        public int Id { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string NoInterior { get; set; }
        public string UsoCfdiver33 { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<CitySet> CitySet { get; set; }
        public virtual ICollection<Edcset> Edcset { get; set; }
        public virtual ICollection<Edeset> Edeset { get; set; }
    }
}
