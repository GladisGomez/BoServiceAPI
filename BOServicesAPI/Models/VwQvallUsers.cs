using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwQvallUsers
    {
        public string Userid { get; set; }
        public string Access { get; set; }
        public string Password { get; set; }
        public string MarcaClienteSa { get; set; }
        public string RegiónVehículoSa { get; set; }
        public string DepósitoVehículoSa { get; set; }
        public string OficialName { get; set; }
        public string NickName { get; set; }
    }
}
