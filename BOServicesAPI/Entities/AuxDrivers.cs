using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    /// <summary>
    /// Clase para el manejo de de entidades de Drivers
    /// </summary>
    public class AuxDrivers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cellular { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
    }
}
