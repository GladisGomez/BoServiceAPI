using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class SynchronizerFilesVersionSet
    {
        public int Id { get; set; }
        public string StationNumber { get; set; }
        public string FilesVersion { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string FtpUpgradeFileName { get; set; }
        public string FtpUpgradeFilePass { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
