using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwGetSiteAccessQv
    {
        public string UserName { get; set; }
        public int UserWebId { get; set; }
        public string AccessProfileQv { get; set; }
        public string Pass { get; set; }
        public int IdCliente { get; set; }
        public int IdCedis { get; set; }
        public string OficialName { get; set; }
        public string NickNameClientgroup { get; set; }
        public string NickNameCedis { get; set; }
    }
}
