using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AlertAuthContingencySet
    {
        public int Id { get; set; }
        public string IdContingency { get; set; }
        public int? IdAlerta { get; set; }
        public DateTime? TimeCarga { get; set; }
        public DateTime? TimeCobro { get; set; }
        public string ComentariosCarga { get; set; }
        public string ComentariosCobro { get; set; }
        public bool? SendMail { get; set; }
        public bool Authorized { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? AlertAuthContingencyContactPerson { get; set; }
        public int? AlertAuthContingencyContactPerson1 { get; set; }

        public virtual ContactPersons AlertAuthContingencyContactPerson1Navigation { get; set; }
        public virtual ContactPersons AlertAuthContingencyContactPersonNavigation { get; set; }
    }
}
