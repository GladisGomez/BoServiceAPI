using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class SerieBillingSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExpeditionPlace { get; set; }
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        public string TypeOfVoucher { get; set; }
        public string FormOfPayment { get; set; }
        public string Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
