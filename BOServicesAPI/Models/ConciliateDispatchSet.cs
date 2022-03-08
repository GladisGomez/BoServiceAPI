﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ConciliateDispatchSet
    {
        public int Id { get; set; }
        public int IdStation { get; set; }
        public string StationNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string Product { get; set; }
        public decimal Cost { get; set; }
        public decimal Volume { get; set; }
        public bool ExistsInGng { get; set; }
        public string NumTransaction { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
