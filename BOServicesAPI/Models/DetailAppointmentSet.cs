using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DetailAppointmentSet
    {
        public DetailAppointmentSet()
        {
            EmployeesAppointmentSet = new HashSet<EmployeesAppointmentSet>();
        }

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
        public int? AppointmentServiceDetailAppointment { get; set; }

        public virtual AppointmentServiceSet AppointmentServiceDetailAppointmentNavigation { get; set; }
        public virtual ICollection<EmployeesAppointmentSet> EmployeesAppointmentSet { get; set; }
    }
}
