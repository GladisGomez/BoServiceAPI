using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DiagnosticReaderSet
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public string FinalDiagnostic { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int DiagnosticReaderLaboratoryDiagnosticReader { get; set; }
        public int? ReaderDiagnosticReader { get; set; }

        public virtual LaboratoryDiagnosticReaderSet DiagnosticReaderLaboratoryDiagnosticReaderNavigation { get; set; }
        public virtual Readers ReaderDiagnosticReaderNavigation { get; set; }
    }
}
