using BOServicesAPI.DBContext;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BOServicesAPI.Entities.CatalogsDTOS;

namespace BOServicesAPI.DataBase
{
    /// <summary>
    /// Clase para el manejo de Catalogos
    /// </summary>
    public class CatalogsDB
    {
        private readonly OxxoBoContext _context;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context"></param>
        public CatalogsDB(OxxoBoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo encargado de obtener la lista de marcas de vehiculo
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxBrandModels> VehicleBrands()
        {
            List<AuxBrandModels> data = new List<AuxBrandModels>();
            try
            {
                data = (from b in _context.BrandModels
                        select new AuxBrandModels
                        {
                            Id = b.Id,
                            ModelName = b.ModelName,
                            TanksQuantity = b.TanksQuantity
                        }).OrderBy(m => m.ModelName).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        /// <summary>
        /// Metodo encargado de obtener la lista de modelos de vehiculo
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxVehicleBrands> VehicleModels()
        {
            List<AuxVehicleBrands> data = new List<AuxVehicleBrands>();
            try
            {
                data = (from v in _context.VehicleBrands
                        select new AuxVehicleBrands
                        {
                            Id = v.Id,
                            Brand = v.Brand
                        }).OrderBy(m => m.Brand).ToList(); 
                        
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }
        public List<AuxCostCenter> CostCenter()
        {
            List<AuxCostCenter> data = new List<AuxCostCenter>();
            try
            {
                data = (from v in _context.CostCenterSet
                        where v.Active ==true
                        select new AuxCostCenter
                        {
                            Id = v.Id,
                            CostCenter  = v.Name  
                        }).OrderBy(m => m.CostCenter ).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }
        /// <summary>
        /// Metodo encargado de obtener la lista de tipos de vehiculos
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        
        public List<AuxVehicleTypes> VehicleTypes()
        {
            List<AuxVehicleTypes> data = new List<AuxVehicleTypes>();
            try
            {
                data = (from v in _context.VehicleTypes
                        select new AuxVehicleTypes
                        {
                            Id = v.Id,
                            Type = v.Type
                        }).OrderBy(m => m.Type).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        /// <summary>
        /// Metodo encargado de obtener la lista de status del vehiculo
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxVehicleStatus> VehicleStatus()
        {
            List<AuxVehicleStatus> data = new List<AuxVehicleStatus>();
            try
            {
                data = (from s in _context.StatusSet
                        select new AuxVehicleStatus
                        {
                            Id = s.Id,
                            NameStatus = s.NameStatus,
                            Enable = s.Enable
                        }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        /// <summary>
        /// Metodo encargado de obtener la lista de tipos de combustible
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxFuelTypes> FuelTypes()
        {
            List<AuxFuelTypes> data = new List<AuxFuelTypes>();
            try
            {
                data = (from f in _context.FuelTypes
                        select new AuxFuelTypes
                        {
                            Id = f.Id,
                            Code = f.Code,
                            Type = f.Type,
                            ShowOnSite = f.ShowOnSite,
                            Price = Convert.ToDouble(f.Price),
                            CveUnidad = f.CveUnidad,
                            DescriptionUnidad = f.DescriptionUnidad
                        }).OrderBy(m => m.Type) .ToList();

            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        /// <summary>
        /// Metodo encargado de obtener la lista de unidades en el odometro
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxOdometerUnits> UnitsOnOdometer()
        {
            List<AuxOdometerUnits> data = new List<AuxOdometerUnits>();
            try
            {
                data = (from o in _context.OdometerUnits
                        select new AuxOdometerUnits
                        {
                            Id = o.Id,
                            Unit = o.Unit

                        }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

    }
}
