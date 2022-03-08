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
    public class WorkLogController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private WorkLogBL _bl;
        private WorkLogDB _db;

        public WorkLogController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _bl = new WorkLogBL(_context, _configuration);
            _db = new WorkLogDB(_context);
        }

        // POST: api/WorkLog 
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to insert a AuditWeb
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("InsertWorkLogData")]
        public IActionResult InsertWorkLogData([FromBody] WorkLog data)
        {
            try
            {
                return Json(_db.InsertWorkLogData(data));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en InsertWorkLogData, message: ´" + ex.Message.ToString() + "´ ");
            }

        }
    }
}
