using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DriversVehiclesSet
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int DriversVehiclesDriver { get; set; }
        public int DriversVehiclesVehicle { get; set; }

        public virtual Drivers DriversVehiclesDriverNavigation { get; set; }
        public virtual Vehicles DriversVehiclesVehicleNavigation { get; set; }
    }
}
