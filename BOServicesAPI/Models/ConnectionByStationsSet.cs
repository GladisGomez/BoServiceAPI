using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ConnectionByStationsSet
    {
        public int Id { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public string Contact { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ConnectionByStationsActivityInStation { get; set; }
        public int ConnectionByStationsEmployee { get; set; }
        public int ConnectionByStationsGasStation1 { get; set; }

        public virtual ActivityInStationSet ConnectionByStationsActivityInStationNavigation { get; set; }
        public virtual Employees ConnectionByStationsEmployeeNavigation { get; set; }
        public virtual GasStations ConnectionByStationsGasStation1Navigation { get; set; }
    }
}
