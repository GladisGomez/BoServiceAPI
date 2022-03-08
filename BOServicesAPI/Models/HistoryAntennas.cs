using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryAntennas
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public int? IdAntenna { get; set; }
        public string Serial { get; set; }
        public string Location { get; set; }
        public DateTime? InstallationDateTime { get; set; }
        public int? MalfunctionAntennas { get; set; }
        public string FolioTheService { get; set; }
        public string Comments { get; set; }
        public string ActualIp { get; set; }
        public bool? Active { get; set; }
        public string CablesLocationDescription { get; set; }
        public string PowerSupplyLocationDescription { get; set; }
        public int? Readers { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int HistoryAntennaGasStation { get; set; }
        public int? HistoryAntennaProducts { get; set; }
        public int? HistoryAntennaReplacementReason { get; set; }

        public virtual GasStations HistoryAntennaGasStationNavigation { get; set; }
        public virtual ProductsSet HistoryAntennaProductsNavigation { get; set; }
        public virtual ReplacementReasons HistoryAntennaReplacementReasonNavigation { get; set; }
    }
}
