using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionReader
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

        public virtual Reader MalfunctionReaderReaderNavigation { get; set; }
        public virtual ReaderStatus MalfunctionReaderReaderStatusNavigation { get; set; }
        public virtual MalfunctionReport MalfunctionReportMalfunctionReaderNavigation { get; set; }
    }
}
