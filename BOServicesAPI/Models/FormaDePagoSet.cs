using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class FormaDePagoSet
    {
        public FormaDePagoSet()
        {
            ClientGroups = new HashSet<ClientGroups>();
            GasStations = new HashSet<GasStations>();
            HistoryGasStationSet = new HashSet<HistoryGasStationSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ClientGroups> ClientGroups { get; set; }
        public virtual ICollection<GasStations> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSet { get; set; }
    }
}
