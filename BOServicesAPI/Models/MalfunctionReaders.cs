using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionReaders
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? DidTryAnotherNozzle { get; set; }
        public bool? IsDefinedCorrectlyInCg { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportMalfunctionReader { get; set; }
        public int MalfunctionReaderReader { get; set; }
        public int? MalfunctionReaderReaderStatus { get; set; }

        public virtual Readers MalfunctionReaderReaderNavigation { get; set; }
        public virtual ReaderStatuses MalfunctionReaderReaderStatusNavigation { get; set; }
        public virtual MalfunctionReports MalfunctionReportMalfunctionReaderNavigation { get; set; }
    }
}
