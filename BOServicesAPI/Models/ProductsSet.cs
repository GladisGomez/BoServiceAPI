using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ProductsSet
    {
        public ProductsSet()
        {
            AccesoriesSet = new HashSet<AccesoriesSet>();
            Antennas = new HashSet<Antennas>();
            BatterySet = new HashSet<BatterySet>();
            GpsSet = new HashSet<GpsSet>();
            HistoryAntennas = new HashSet<HistoryAntennas>();
            HistoryGpsSet = new HashSet<HistoryGpsSet>();
            Meters = new HashSet<Meters>();
            Readers = new HashSet<Readers>();
            Tags = new HashSet<Tags>();
        }

        public int Id { get; set; }
        public string CodProd { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Unidad { get; set; }
        public bool? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ProductSectionProducts { get; set; }

        public virtual ProductSectionSet ProductSectionProductsNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSet { get; set; }
        public virtual ICollection<Antennas> Antennas { get; set; }
        public virtual ICollection<BatterySet> BatterySet { get; set; }
        public virtual ICollection<GpsSet> GpsSet { get; set; }
        public virtual ICollection<HistoryAntennas> HistoryAntennas { get; set; }
        public virtual ICollection<HistoryGpsSet> HistoryGpsSet { get; set; }
        public virtual ICollection<Meters> Meters { get; set; }
        public virtual ICollection<Readers> Readers { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
