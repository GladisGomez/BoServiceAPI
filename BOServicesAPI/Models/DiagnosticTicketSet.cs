using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DiagnosticTicketSet
    {
        public DiagnosticTicketSet()
        {
            TicketEventsSet = new HashSet<TicketEventsSet>();
            TicketSet = new HashSet<TicketSet>();
        }

        public int Id { get; set; }
        public int IdError { get; set; }
        public string ErrorMessage { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<TicketEventsSet> TicketEventsSet { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
    }
}
