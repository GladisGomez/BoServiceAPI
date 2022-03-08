using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AlertasSet
    {
        public int Id { get; set; }
        public string NameAlarm { get; set; }
        public string MessageAlarm { get; set; }
        public string ActionAlarm { get; set; }
        public bool? Active { get; set; }
        public string Screen { get; set; }
        public string TypeSet { get; set; }
        public string ValueSet { get; set; }
        public string SetAttribute { get; set; }
        public int? IdSet { get; set; }
        public string SubjectMail { get; set; }
        public string BodyMail { get; set; }
        public string ToMail { get; set; }
        public bool SendMail { get; set; }
        public string IdScreen { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
