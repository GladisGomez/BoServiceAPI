using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            ClientGroups = new HashSet<ClientGroups>();
            Clients = new HashSet<Clients>();
            ContactPersons = new HashSet<ContactPersons>();
            GasStations = new HashSet<GasStations>();
            HistoryGasStationSet = new HashSet<HistoryGasStationSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public bool AddressForMail { get; set; }
        public bool OficialAddress { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Colony { get; set; }
        public string City { get; set; }
        public string Cp { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? AddressCity { get; set; }
        public int AddressCountry { get; set; }

        public virtual CitySet AddressCityNavigation { get; set; }
        public virtual Countries AddressCountryNavigation { get; set; }
        public virtual ICollection<ClientGroups> ClientGroups { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
        public virtual ICollection<ContactPersons> ContactPersons { get; set; }
        public virtual ICollection<GasStations> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSet { get; set; }
    }
}
