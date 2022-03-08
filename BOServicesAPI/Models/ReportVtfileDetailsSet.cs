using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReportVtfileDetailsSet
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public int ColumnsNumber { get; set; }
        public int ColumnPlate { get; set; }
        public int ColumnEcoNumber { get; set; }
        public string Header { get; set; }
        public string Path { get; set; }
        public int RowStart { get; set; }
        public bool Status { get; set; }
        public int DateColumn { get; set; }
        public int OutputHourColumn { get; set; }
        public int InputHourColumn { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ReportVtemailsReportVtfileDetails { get; set; }

        public virtual ReportVts ReportVtemailsReportVtfileDetailsNavigation { get; set; }
    }
}
