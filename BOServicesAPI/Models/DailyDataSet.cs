using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DailyDataSet
    {
        public int Id { get; set; }
        public string Variable { get; set; }
        public string Value { get; set; }
        public string Table { get; set; }
        public int? IdRecord { get; set; }
        public DateTime? DateChange { get; set; }
        public string EventSql { get; set; }
        public string UserEvent { get; set; }
        public string DataSource { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
