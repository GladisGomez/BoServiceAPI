using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class AuxContingencies
    {
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
    }
}
