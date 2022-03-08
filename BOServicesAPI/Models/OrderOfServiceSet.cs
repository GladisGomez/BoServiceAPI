using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class OrderOfServiceSet
    {
        public OrderOfServiceSet()
        {
            TicketDetailMovementsSet = new HashSet<TicketDetailMovementsSet>();
            TicketSet = new HashSet<TicketSet>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public string Comments { get; set; }
        public bool VoBo { get; set; }
        public int? Number { get; set; }
        public int? OrderOfServiceAppointmentService { get; set; }
        public int OrderOfServiceEmployee { get; set; }
        public int OrderOfServiceEmployee1 { get; set; }
        public int StatusOrderOrderOfService { get; set; }
        public int TypeOfServiceByAreaOrderOfService { get; set; }

        public virtual AppointmentServiceSet OrderOfServiceAppointmentServiceNavigation { get; set; }
        public virtual Employees OrderOfServiceEmployee1Navigation { get; set; }
        public virtual Employees OrderOfServiceEmployeeNavigation { get; set; }
        public virtual StatusOrderSet StatusOrderOrderOfServiceNavigation { get; set; }
        public virtual TypeOfServiceByAreaSet TypeOfServiceByAreaOrderOfServiceNavigation { get; set; }
        public virtual ICollection<TicketDetailMovementsSet> TicketDetailMovementsSet { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
    }
}
