using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using BOServicesAPI.Entities.CustomizationSticker;
using BOServicesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    /// <summary>
    /// Clase para el manejo de consultas para Drivers
    /// </summary>
    public class DriversDB
    {
        private readonly OxxoBoContext _context;

        public DriversDB(OxxoBoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de Drivers
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxDrivers> GetDrivers()
        {
            List<AuxDrivers> data = new List<AuxDrivers>();
            try
            {
                data = (from d in _context.Drivers
                        select new AuxDrivers
                        {
                            Id = d.Id,
                            Name = d.Name,
                            Cellular = d.Cellular
                            
                        }).OrderBy(m => m.Name).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }

        /// <summary>
        /// Metodo encargado de insertar un driver en base de datos
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public Result InsertDriverData(AuxDrivers auxData)
        {
            Result result = new Result();

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Drivers data = new Drivers()
                    {
                        Name = auxData.Name,
                        Cellular = auxData.Cellular,
                        CreatedBy = auxData.CreatedBy,
                        Created = DateTimeOffset.Now
                    };

                    _context.Drivers.Add(data);
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.result = 2;
                    result.message = ex.Message;
                    transaction.Rollback();

                }

                result.result = 1;
                result.message = "Success";
                return result;
            }
        }
    }
}
