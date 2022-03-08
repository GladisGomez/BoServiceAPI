using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ContingencySet
    {
        public ContingencySet()
        {
            CallRecordSet = new HashSet<CallRecordSet>();
            ContingencyFileSet = new HashSet<ContingencyFileSet>();
            DispatchSet = new HashSet<DispatchSet>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime DateTimeContingency { get; set; }
        public string NumberTransaction { get; set; }
        public string NumberPump { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public double QuantityReal { get; set; }
        public double AmountReal { get; set; }
        public string NameDispatcher { get; set; }
        public string MessageError { get; set; }
        public string Comments { get; set; }
        public DateTime? DateFinishFinanzas { get; set; }
        public string PathInvoice { get; set; }
        public string NcontrolGas { get; set; }
        public DateTime? DateFinishAtcnoc { get; set; }
        public decimal? PriceUnit { get; set; }
        public int? ParentId { get; set; }
        public string CommentsCancel { get; set; }
        public bool WithInternet { get; set; }
        public DateTime DatetimeStamp { get; set; }
        public bool Used { get; set; }
        public decimal? Odometer { get; set; }
        public int? TypeContingency { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ContingencyClientGroup { get; set; }
        public int? ContingencyDriver { get; set; }
        public int? ContingencyEmployee { get; set; }
        public int? ContingencyEmployee1 { get; set; }
        public int ContingencyFuelType { get; set; }
        public int? ContingencyGasStation { get; set; }
        public int? ContingencyStatusContingency { get; set; }
        public int? ContingencyTypeContigency { get; set; }
        public int ContingencyVehicle { get; set; }

        public virtual ClientGroups ContingencyClientGroupNavigation { get; set; }
        public virtual Drivers ContingencyDriverNavigation { get; set; }
        public virtual Employees ContingencyEmployee1Navigation { get; set; }
        public virtual Employees ContingencyEmployeeNavigation { get; set; }
        public virtual FuelTypes ContingencyFuelTypeNavigation { get; set; }
        public virtual GasStations ContingencyGasStationNavigation { get; set; }
        public virtual StatusContingencySet ContingencyStatusContingencyNavigation { get; set; }
        public virtual TypeContigencySet ContingencyTypeContigencyNavigation { get; set; }
        public virtual Vehicles ContingencyVehicleNavigation { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSet { get; set; }
        public virtual ICollection<ContingencyFileSet> ContingencyFileSet { get; set; }
        public virtual ICollection<DispatchSet> DispatchSet { get; set; }
    }
}
