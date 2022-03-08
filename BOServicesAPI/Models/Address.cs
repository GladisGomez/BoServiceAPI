using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Address
    {
        public Address()
        {
            ClientGroups = new HashSet<ClientGroup>();
            Clients = new HashSet<Client>();
            ContactPeople = new HashSet<ContactPerson>();
            GasStations = new HashSet<GasStation>();
            HistoryGasStationSets = new HashSet<HistoryGasStationSet>();
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
        public virtual Country AddressCountryNavigation { get; set; }
        public virtual ICollection<ClientGroup> ClientGroups { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<GasStation> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSets { get; set; }
    }
}
