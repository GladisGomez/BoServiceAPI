using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DispatchSet
    {
        public DispatchSet()
        {
            DispatchExSet = new HashSet<DispatchExSet>();
        }

        public int Id { get; set; }
        public bool? RecordOk { get; set; }
        public DateTime DatetimeStamp { get; set; }
        public string TransactionInternalId { get; set; }
        public string CgCommand { get; set; }
        public int? NumTransaction { get; set; }
        public DateTime DatetimeStart { get; set; }
        public decimal? BaseBalance { get; set; }
        public decimal? AllocateVolume { get; set; }
        public decimal? AllocateCost { get; set; }
        public bool? AllocatedReturn { get; set; }
        public DateTime? DatetimeEnd { get; set; }
        public bool? UpdatedOffline { get; set; }
        public decimal? RealVolume { get; set; }
        public decimal? RealCost { get; set; }
        public decimal? PriceUnit { get; set; }
        public int? PumpNumber { get; set; }
        public decimal? Odometer { get; set; }
        public decimal? EngineHours { get; set; }
        public bool TotvsUpdated { get; set; }
        public bool Canceled { get; set; }
        public string Comments { get; set; }
        public DateTime DatetimeFeed { get; set; }
        public int? Tar { get; set; }
        public decimal? Ieps { get; set; }
        public int? DispatchType { get; set; }
        public DateTime? DatetimeInvoicing { get; set; }
        public int? ContingencyError { get; set; }
        public int? ContingencySingleEvent { get; set; }
        public string DriverName { get; set; }
        public string NameCenterCost { get; set; }
        public decimal DeltaValue { get; set; }
        public string NumTransactionExternal { get; set; }
        public bool DispatchExtern { get; set; }
        public string OldNameCedi { get; set; }
        public DateTime? DatetimeCanceled { get; set; }
        public DateTime? OdometerModified { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? BillingDispatch { get; set; }
        public int? DispatchBilling { get; set; }
        public int? ContingencyDispatch { get; set; }
        public int DispatchFuelType2 { get; set; }
        public int DispatchGasStation { get; set; }
        public int? ProductCodeDispatch { get; set; }
        public int DispatchVehicle { get; set; }

        public virtual BillingSet BillingDispatchNavigation { get; set; }
        public virtual ContingencySet ContingencyDispatchNavigation { get; set; }
        public virtual BillingSet DispatchBillingNavigation { get; set; }
        public virtual FuelTypes DispatchFuelType2Navigation { get; set; }
        public virtual GasStations DispatchGasStationNavigation { get; set; }
        public virtual Vehicles DispatchVehicleNavigation { get; set; }
        public virtual ProductCodeSet ProductCodeDispatchNavigation { get; set; }
        public virtual ICollection<DispatchExSet> DispatchExSet { get; set; }
    }
}
