using BOServicesAPI.DBContext;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.BusinessLogic
{
    /// <summary>
    /// Clase para el manejo de la capa logica de Catalogos
    /// </summary>
    public class CatalogsBL
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context"></param>
        /// <param name="configuration"></param>
        public CatalogsBL(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
    }
}
