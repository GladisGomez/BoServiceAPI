using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryGpsSet
    {
        public int Id { get; set; }
        public int? IdGps { get; set; }
        public string UnitId { get; set; }
        public string UnitIdhex { get; set; }
        public string Fw { get; set; }
        public string ParamVersion { get; set; }
        public DateTime? DateInstallation { get; set; }
        public decimal? ValorOdometer { get; set; }
        public DateTime? OdometerDate { get; set; }
        public string Comentarios { get; set; }
        public bool? Verified { get; set; }
        public bool? Active { get; set; }
        public string Simgps { get; set; }
        public string UnitType { get; set; }
        public string Box { get; set; }
        public string Imei { get; set; }
        public DateTime? DatePackage { get; set; }
        public DateTime? DateGpsSim { get; set; }
        public int? IdClientGate { get; set; }
        public bool? SentTelephony { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int HistoryGpsEmployee { get; set; }
        public int? HistoryGpsGpsParameters { get; set; }
        public int? HistoryGpsGpsVersion { get; set; }
        public int? HistoryGpsProducts { get; set; }
        public int? HistoryGpsStatus { get; set; }
        public int? HistoryGpsVehicle { get; set; }

        public virtual Employees HistoryGpsEmployeeNavigation { get; set; }
        public virtual GpsParametersSet HistoryGpsGpsParametersNavigation { get; set; }
        public virtual GpsVersionSet HistoryGpsGpsVersionNavigation { get; set; }
        public virtual ProductsSet HistoryGpsProductsNavigation { get; set; }
        public virtual StatusSet HistoryGpsStatusNavigation { get; set; }
        public virtual Vehicles HistoryGpsVehicleNavigation { get; set; }
    }
}
