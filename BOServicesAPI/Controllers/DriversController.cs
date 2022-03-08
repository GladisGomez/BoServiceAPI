using BOServicesAPI.BusinessLogic;
using BOServicesAPI.DataBase;
using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DriversController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private DriversBL _bl;
        private DriversDB _db;

        public DriversController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _bl = new DriversBL(_context, _configuration);
            _db = new DriversDB(_context);
        }

        // GET: api/Drivers    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Drivers
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetDrivers")]
        public IEnumerable<AuxDrivers> GetDrivers()
        {
            try
            {
                return _db.GetDrivers();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // POST: api/Drivers    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to insert a Driver
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("InsertDriverData")]
        public IActionResult InsertDriverData([FromBody] AuxDrivers data)
        {
            try
            {
                return Json(_db.InsertDriverData(data));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en InsertDriverData, message: ´" + ex.Message.ToString() + "´ ");
            }

        }

    }
}
