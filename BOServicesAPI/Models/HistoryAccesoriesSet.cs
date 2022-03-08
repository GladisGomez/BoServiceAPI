using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryAccesoriesSet
    {
        public int Id { get; set; }
        public int? IdAccesories { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? ActivationDateTime { get; set; }
        public bool? Active { get; set; }
        public DateTime? ServiceDataTime { get; set; }
        public string FolioTheService { get; set; }
        public string Comments { get; set; }
        public string FisicalLocation { get; set; }
        public string ProductsAccesories { get; set; }
        public string GpsAccesories { get; set; }
        public string VehiclesAccesories { get; set; }
        public string GasStationsAccesories { get; set; }
        public string TestingProductsAccesories { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? HistoryAccesoriesReplacementReason { get; set; }
        public int? HistoryAccesoriesTreatmentType { get; set; }

        public virtual ReplacementReasons HistoryAccesoriesReplacementReasonNavigation { get; set; }
        public virtual TreatmentTypes HistoryAccesoriesTreatmentTypeNavigation { get; set; }
    }
}
