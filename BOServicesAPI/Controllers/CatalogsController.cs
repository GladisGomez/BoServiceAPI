using BOServicesAPI.BusinessLogic;
using BOServicesAPI.DataBase;
using BOServicesAPI.DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using static BOServicesAPI.Entities.CatalogsDTOS;

namespace BOServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CatalogsController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private CatalogsBL _bl;
        private CatalogsDB _db;

        public CatalogsController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _bl = new CatalogsBL(_context, _configuration);
            _db = new CatalogsDB(_context);
        }



        // GET: api/Catalogs    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Vehicle Brands
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetVehicleBrands")]
        public IEnumerable<AuxBrandModels> GetVehicleBrands()
        {
            try
            {
                return _db.VehicleBrands();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Catalogs    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Vehicle Models
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetVehicleModels")]
        public IEnumerable<AuxVehicleBrands> GetVehicleModels()
        {
            try
            {
                return _db.VehicleModels();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Catalogs    
        //<created>Gerardo Vilchis</created>
        /// <summary>Use this resource to get a list of Cost Center
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>        
        [Produces("application/json")]
        [HttpGet("GetCostCenter")]
        public IEnumerable<AuxCostCenter> GetVehicleCostCenter()
        {
            try
            {
                return _db.CostCenter();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Catalogs    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Vehicle Types
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetVehicleTypes")]
        public IEnumerable<AuxVehicleTypes> GetVehicleTypes()
        {
            try
            {
                return _db.VehicleTypes();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Catalogs    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Vehicle Status
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetVehicleStatus")]
        public IEnumerable<AuxVehicleStatus> GetVehicleStatus()
        {
            try
            {
                return _db.VehicleStatus();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Catalogs    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Fuel Types
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetFuelTypes")]
        public IEnumerable<AuxFuelTypes> GetFuelTypes()
        {
            try
            {
                return _db.FuelTypes();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Catalogs    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Units on the odometer
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetUnitsOnOdometer")]
        public IEnumerable<AuxOdometerUnits> GetUnitsOnOdometer()
        {
            try
            {
                return _db.UnitsOnOdometer();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }  

}
