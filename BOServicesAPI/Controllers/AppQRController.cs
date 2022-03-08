using BOServicesAPI.BusinessLogic;
using BOServicesAPI.DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class AppQRController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly AppQRBL _bl;

        public AppQRController(OxxoBoContext context)
        {
            _context = context;
            _bl = new AppQRBL(_context);
        }

      
    }
}
