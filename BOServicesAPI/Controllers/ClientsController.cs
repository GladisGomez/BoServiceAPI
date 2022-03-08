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
    public class ClientsController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private ClientsDB _db;

       public ClientsController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _db = new ClientsDB(_context, _configuration);
        }

        // POST: api/Clients  
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of clients
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetListClientsByUserNameWeb")]
        public IEnumerable<AuxClients> GetListClientsByUserNameWeb(string userName)
        {
            try
            {
                return _db.GetListClientsInUserWeb(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //// POST: api/Clients  
        ////<created>Daniel Munguia</created>
        ///// <summary>Use this resource to get a list of cedis
        ///// </summary>  
        ///// <response code="200">Data correctly</response>        
        ///// <response code="400">BadRequest.</response>      
        ///// <response code="401">Unauthorized.</response>         

        //[Produces("application/json")]
        //[HttpPost("GetListCedisByUserNameWeb")]
        //public IEnumerable<AuxClients> GetListCedisByUserNameWeb(string userName)
        //{
        //    try
        //    {
        //        return _db.GetListClientGroupsInUserWeb(userName);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        // POST: api/Clients  
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of cedis
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetListCedisByUserNameWebAndClientGroup")]
        public IEnumerable<AuxClients> GetListCedisByUserNameWebAndClientGroup(string userName, int clientG)
        {
            try
            {
                return _db.GetListClientInUserWebByClientGroupAndUserName(userName, clientG);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // POST: api/Clients  
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of cedis
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetListCedisByClientGroup")]
        public IEnumerable<AuxClients> GetListCedisByClientGroup(int clientG)
        {
            try
            {
                return _db.GetListCedisByClientGroup(clientG);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
