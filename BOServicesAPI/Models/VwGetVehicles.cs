using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwGetVehicles
    {
        public int Id { get; set; }
        public string OficialName { get; set; }
        public string NickName { get; set; }
        public string ModelName { get; set; }
        public string Plate { get; set; }
        public string EcoNumber { get; set; }
        public string NameStatus { get; set; }
        public string SearchProperty1 { get; set; }
        public string SearchProperty2 { get; set; }
        public string Vin { get; set; }
        public int PublicId { get; set; }
        public DateTimeOffset? Created { get; set; }
        public int IdClientGroups { get; set; }
        public int IdClients { get; set; }
        public int? RulesVehicle { get; set; }
        public string CostCenter { get; set; }
    }
}
