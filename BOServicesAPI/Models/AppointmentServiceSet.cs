using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AppointmentServiceSet
    {
        public AppointmentServiceSet()
        {
            CatDeviceSet = new HashSet<CatDeviceSet>();
            DetailAppointmentSet = new HashSet<DetailAppointmentSet>();
            DeteilAppointmentSet = new HashSet<DeteilAppointmentSet>();
            OrderOfServiceSet = new HashSet<OrderOfServiceSet>();
            TicketDetailMovementsSet = new HashSet<TicketDetailMovementsSet>();
            TicketSet = new HashSet<TicketSet>();
            Vehicles = new HashSet<Vehicles>();
        }

        public int Id { get; set; }
        public DateTime DateAppointment { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Coments { get; set; }
        public DateTime DateFinish { get; set; }
        public bool Finish { get; set; }
        public DateTime? DateRealFinish { get; set; }
        public bool Cancel { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int AppointmentServiceCity { get; set; }
        public int? AppointmentServiceEmployee { get; set; }
        public int? AppointmentServiceStatusAppointment { get; set; }
        public int AppointmentServiceTaskPriority { get; set; }
        public int AppointmentServiceTypeOfService { get; set; }

        public virtual CitySet AppointmentServiceCityNavigation { get; set; }
        public virtual Employees AppointmentServiceEmployeeNavigation { get; set; }
        public virtual StatusAppointmentSet AppointmentServiceStatusAppointmentNavigation { get; set; }
        public virtual TaskPrioritySet AppointmentServiceTaskPriorityNavigation { get; set; }
        public virtual TypeOfServiceSet AppointmentServiceTypeOfServiceNavigation { get; set; }
        public virtual ICollection<CatDeviceSet> CatDeviceSet { get; set; }
        public virtual ICollection<DetailAppointmentSet> DetailAppointmentSet { get; set; }
        public virtual ICollection<DeteilAppointmentSet> DeteilAppointmentSet { get; set; }
        public virtual ICollection<OrderOfServiceSet> OrderOfServiceSet { get; set; }
        public virtual ICollection<TicketDetailMovementsSet> TicketDetailMovementsSet { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
