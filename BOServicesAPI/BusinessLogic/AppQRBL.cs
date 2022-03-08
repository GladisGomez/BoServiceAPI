using BOServicesAPI.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOServicesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BOServicesAPI.BusinessLogic
{
    /// <summary>
    /// Clase encargada de la gestion de subrutinas que ocupa la AppQRScannerStickers
    /// </summary>
    public class AppQRBL
    {
        private readonly OxxoBoContext _context;
        public AppQRBL(OxxoBoContext context)
        {
            _context = context;
        }

  
    }
}
