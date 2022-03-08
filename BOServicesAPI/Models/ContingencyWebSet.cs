using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ContingencyWebSet
    {
        public ContingencyWebSet()
        {
            ContingencyWithoutVehicleSet = new HashSet<ContingencyWithoutVehicleSet>();
        }

        public int Id { get; set; }
        public string SendNumber { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string PathFiles { get; set; }
        public bool Satus { get; set; }
        public string Comments { get; set; }
        public string IdContingency { get; set; }
        public bool? Asociado { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ContingencyWebGasStation1 { get; set; }

        public virtual GasStations ContingencyWebGasStation1Navigation { get; set; }
        public virtual ICollection<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSet { get; set; }
    }
}
