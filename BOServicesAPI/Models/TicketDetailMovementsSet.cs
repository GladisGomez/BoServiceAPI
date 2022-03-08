﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TicketDetailMovementsSet
    {
        public int Id { get; set; }
        public int NumberOfTicket { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int TicketDetailMovementsAppointmentService { get; set; }
        public int? TicketDetailMovementsOrderOfService { get; set; }
        public int? TicketDetailMovementsTicket { get; set; }

        public virtual AppointmentServiceSet TicketDetailMovementsAppointmentServiceNavigation { get; set; }
        public virtual OrderOfServiceSet TicketDetailMovementsOrderOfServiceNavigation { get; set; }
        public virtual TicketSet TicketDetailMovementsTicketNavigation { get; set; }
    }
}
