using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class RevisionMeterSet
    {
        public int Id { get; set; }
        public DateTime RevisionDate { get; set; }
        public double KmMeter { get; set; }
        public double KmVehicle { get; set; }
        public string RevisionComments { get; set; }
        public double RadioBefore { get; set; }
        public double RadioNew { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int RevisionMeterEmployee { get; set; }
        public int RevisionMeterErrorRevisionMeter { get; set; }
        public int? MeterRevisionMeter { get; set; }
        public int RevisionMeterStatusRevisionMeter { get; set; }

        public virtual Meters MeterRevisionMeterNavigation { get; set; }
        public virtual Employees RevisionMeterEmployeeNavigation { get; set; }
        public virtual ErrorRevisionMeterSet RevisionMeterErrorRevisionMeterNavigation { get; set; }
        public virtual StatusRevisionMeterSet RevisionMeterStatusRevisionMeterNavigation { get; set; }
    }
}
