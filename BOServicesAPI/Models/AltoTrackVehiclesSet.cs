using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AltoTrackVehiclesSet
    {
        public int Id { get; set; }
        public int IdVehicle { get; set; }
        public string Plate { get; set; }
        public string EcoNumber { get; set; }
        public bool Active { get; set; }
        public string Cedi { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
