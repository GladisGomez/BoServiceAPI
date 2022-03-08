using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ControlPrintTargetSet
    {
        public int Id { get; set; }
        public string Sid { get; set; }
        public string Comentarios { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ControlPrintTargetEmployee { get; set; }
        public int ControlPrintTargetRePrintTargetReason { get; set; }
        public int ControlPrintTargetTag { get; set; }
        public int ControlPrintTargetVehicle { get; set; }

        public virtual Employees ControlPrintTargetEmployeeNavigation { get; set; }
        public virtual RePrintTargetReasonSet ControlPrintTargetRePrintTargetReasonNavigation { get; set; }
        public virtual Tags ControlPrintTargetTagNavigation { get; set; }
        public virtual Vehicles ControlPrintTargetVehicleNavigation { get; set; }
    }
}
