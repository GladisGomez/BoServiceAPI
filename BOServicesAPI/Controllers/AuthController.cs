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
    
    public class AuthController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private AuthBL _bl;
        private AuthDB _db;


        public AuthController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _bl = new AuthBL(_context,_configuration);
            _db = new AuthDB(_context);

        }

        // POST: api/Auth    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to validate a user credentials
        /// </summary>  
        /// <response code="200">Data correctly, user valid</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("ValidateLogin")]
        public IActionResult ValidateLogin(UserDTOS request)
        {
            try
            {
                return Json(_bl.ValidateCredentials(request));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en ValidateLogin, message: ´" + ex.Message.ToString() + "´ ");
            }

        }

        // POST: api/Auth    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a user id for user logged
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetUserIdLogged")]
        public IActionResult GetUserIdLogged(string username)
        {
            try
            {
                return Json(_db.GetUserId(username));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en GetUserIdLogged, message: ´" + ex.Message.ToString() + "´ ");
            }

        }

        // POST: api/Auth    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a FirstName for user logged
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetUserFirstNameLogged")]
        public IActionResult GetUserFirstNameLogged(string username)
        {
            try
            {
                return Json(_db.GetUserName(username));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en GetUserFirstNameLogged, message: ´" + ex.Message.ToString() + "´ ");
            }

        }
    }
}
