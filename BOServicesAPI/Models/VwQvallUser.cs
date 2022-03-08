using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwQvallUser
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
