using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DeteilAppointmentSet
    {
        public int Id { get; set; }
        public DateTime DateAppointment { get; set; }
        public DateTime DateAproxFinish { get; set; }
        public DateTime? DateRealFinish { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? AppointmentServiceDeteilAppointment1 { get; set; }

        public virtual AppointmentServiceSet AppointmentServiceDeteilAppointment1Navigation { get; set; }
    }
}
