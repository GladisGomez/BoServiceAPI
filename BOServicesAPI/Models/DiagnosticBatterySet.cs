using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DiagnosticBatterySet
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public bool Repaired { get; set; }
        public bool Use { get; set; }
        public string FinalDiagnostic { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? BatteryDiagnosticBattery { get; set; }
        public int DiagnosticBatteryLaboratoryDiagnosticBattery { get; set; }

        public virtual BatterySet BatteryDiagnosticBatteryNavigation { get; set; }
        public virtual LaboratoryDiagnosticBatterySet DiagnosticBatteryLaboratoryDiagnosticBatteryNavigation { get; set; }
    }
}
