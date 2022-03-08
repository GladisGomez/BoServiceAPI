using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using BOServicesAPI.Entities.CustomizationSticker;
using BOServicesAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    public class VehiclesDB
    {
        private readonly OxxoBoContext _context;
        private WorkLogDB _workLog;

        public VehiclesDB(OxxoBoContext context)
        {
            _context = context;
            _workLog = new WorkLogDB(_context);
        }

        /// <summary>
        /// Metodo encargado de obtener un Vehiculo buscado por placa
        /// </summary>
        /// <param name="plate"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public int GetIdVehicleByPlate(string plate)
        {
            int result = 0;

            try
            {
                result = (from x in _context.Vehicles where x.Plate == plate select x.Id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        /// <summary>
        /// Metodo encargado de obtener un vehiculo buscado por ECO
        /// </summary>
        /// <param name="eco"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public int GetIdVehicleByEco(string eco)
        {
            int result = 0;

            try
            {
                result = (from x in _context.Vehicles where x.EcoNumber == eco select x.Id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        /// <summary>
        /// Metodo encargado de obtener una lista de vehiculos asignados a un Usuario del Sitio Web
        /// </summary>
        /// <param name="UserWeb">Username de usuario de UserWebSet</param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxVehicles> listVehicles(string UserWeb)
        {
            List<AuxVehicles> data = new List<AuxVehicles>();

            try
            {
                data = (from c in _context.Clients
                        join cl in _context.ClientGroups on c.ClientGroupClientNavigation.Id equals cl.Id
                        join v in _context.Vehicles on c.Id equals v.VehicleClientNavigation.Id
                        join clg in _context.UsersInClientGroupSet on cl.Id equals clg.UsersInClientGroupClientGroupNavigation.Id
                        join us in _context.UserWebSet on clg.UsersInClientGroupUserWebNavigation.Id equals us.Id
                        join tag in _context.Tags on v.Id equals tag.TagVehicleNavigation.Id into TagVehicles
                        from tagV in TagVehicles.DefaultIfEmpty()
                        where us.UserName == UserWeb
                        select new AuxVehicles
                        {
                            Plate = v.Plate,
                            EcoNumber = v.EcoNumber,
                            StickerAsociado = tagV.Uid,
                            SID = tagV.Sid,
                            TagOrStickerActive = tagV.Active.ToString()

                        }).ToList();


                return data.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Metodo encargado de obtener una lista de vehiculos asignados a un Usuario del Sitio Web por cedi seleccionado
        /// </summary>
        /// <param name="Cedi"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxVehicles> listVehiclesByCedi(int Cedi)
        {
            List<AuxVehicles> data = new List<AuxVehicles>();

            try
            {
                data = (from c in _context.Clients
                        join cl in _context.ClientGroups on c.ClientGroupClientNavigation.Id equals cl.Id
                        join v in _context.Vehicles on c.Id equals v.VehicleClientNavigation.Id

                        where c.Id == Cedi
                        select new AuxVehicles
                        {
                            Id = v.Id,
                            Plate = v.Plate,
                            EcoNumber = v.EcoNumber

                        }).ToList();


                return data.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Metodo encargado de obtener una lista de Stickers asociados a un vehiculo
        /// </summary>
        /// <param name="idVehicle"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxVehicles> listStickersByIdVehicle(int idVehicle)
        {
            List<AuxVehicles> data = new List<AuxVehicles>();

            try
            {
                data = (from c in _context.Tags
                        where c.TagVehicleNavigation.Id == idVehicle && c.Sid.Length > 30
                        select new AuxVehicles
                        {

                            StickerAsociado = c.Uid,
                            SID = c.Sid,
                            TagOrStickerActive = c.Active.ToString()

                        }).ToList();


                return data.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Metodo encargado de insertar un vehiculo en base de datos
        /// </summary>
        /// <param name="auxData"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public Result insertUpdateVehicleData(VehicleData auxData)
        {
            Result result = new Result();
            Vehicles auxVehicle = new Vehicles();
            AuthDB auth = new AuthDB(_context);

            var validate = ValidaNullData(auxData);
            if (validate.result == 1)
            {

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {

                        //Se valida si ya existe el vehiculo
                        auxVehicle = (from v in _context.Vehicles
                                          where v.EcoNumber == auxData.EcoNumber && v.Plate == auxData.Plate
                                          select v).FirstOrDefault();

                        if (auxVehicle == null) { auxVehicle = new Vehicles(); }
                        auxVehicle.Plate = auxData.Plate;
                        auxVehicle.Vin = auxData.Vin;
                        auxVehicle.EcoNumber = auxData.EcoNumber;
                        auxVehicle.PublicId = getPublicNumber();
                        auxVehicle.YearModel = auxData.YearModel;
                        auxVehicle.Verified = auxData.Verified;
                        auxVehicle.Comments = auxData.Comments;
                        auxVehicle.Service = auxData.Service;
                        auxVehicle.HelpNameEmployee = auxData.HelpNameEmployee;
                        auxVehicle.HelpComentsTicket = auxData.HelpComentsTicket;
                        auxVehicle.ReportOdometer = auxData.ReportOdometer;
                        auxVehicle.WithTempValues = auxData.WithTempValues;
                        auxVehicle.WithTempValuesDate = auxData.WithTempValuesDate;
                        auxVehicle.ExtraordinaryDatetime = auxData.ExtraordinaryDatetime;
                        auxVehicle.TotvsUpdated = auxData.TotvsUpdated;
                        auxVehicle.ChangeTotvs = auxData.ChangeTotvs;
                        auxVehicle.SearchProperty1 = auxData.SearchProperty1;
                        auxVehicle.SearchProperty2 = auxData.SearchProperty2;
                        auxVehicle.SingleEventDatetimeStart = auxData.SingleEventDatetimeStart;
                        auxVehicle.SingleEventDatetimeEnd = auxData.SingleEventDatetimeEnd;
                        auxVehicle.SingleEventMaxCost = auxData.SingleEventMaxCost;
                        auxVehicle.SingleEventMaxVolume = auxData.SingleEventMaxVolume;
                        auxVehicle.SingleEventFuelType = auxData.SingleEventFuelType;
                        auxVehicle.NumTransactionExternal = auxData.NumTransactionExternal;
                        auxVehicle.IdClientGate = auxData.IdClientGate;
                        auxVehicle.EstimatedFuelCons = auxData.EstimatedFuelCons;
                        auxVehicle.IsParent = auxData.IsParent;
                        auxVehicle.IsCloned = auxData.IsCloned;
                        auxVehicle.CancelEvent = auxData.CancelEvent;
                        auxVehicle.CreatedBy = auxData.CreatedBy;
                        auxVehicle.Created = DateTimeOffset.Now;


                        if (auxData.AppointmentServiceVehicle > 0)
                        {
                            auxVehicle.AppointmentServiceVehicle = auxData.AppointmentServiceVehicle;
                        }
                        if (auxData.CostCenterVehicle > 0)
                        {
                            auxVehicle.CostCenterVehicle = auxData.CostCenterVehicle;
                        }
                        if (auxData.RulesVehicle > 0)
                        {
                            auxVehicle.RulesVehicle = auxData.RulesVehicle;
                        }
                        if (auxData.VehicleBrandModel > 0)
                        {
                            auxVehicle.VehicleBrandModel = auxData.VehicleBrandModel;
                        }
                        if (auxData.VehicleClient > 0)
                        {
                            auxVehicle.VehicleClient = auxData.VehicleClient;
                        }
                        if (auxData.VehicleFuelType > 0)
                        {
                            auxVehicle.VehicleFuelType = auxData.VehicleFuelType;
                        }
                        if (auxData.VehicleStatus > 0)
                        {
                            auxVehicle.VehicleStatus = auxData.VehicleStatus;
                        }
                        if (auxData.VehicleVehicleBrand > 0)
                        {
                            auxVehicle.VehicleVehicleBrand = auxData.VehicleVehicleBrand;
                        }


                        //Cuando se selecciona el modelo y el campo EstimatedFuelCons de vehicles es 0 hay que seleccionar(tambien valida si el Id de vehiculo es 0 hace el cambio y si no es 0 no lo va a cambiar)
                        //el valor default que viene en la descripcion del modelo[tabla BrandModels campo DefaultEstimatedCons]
                        if (auxVehicle.EstimatedFuelCons <= 0 && auxVehicle.VehicleBrandModel > 0)
                        {
                            auxVehicle.EstimatedFuelCons = (from n in _context.BrandModels
                                                            where n.BrandModelVehicleBrandNavigation.Id == auxVehicle.VehicleBrandModel
                                                            select n.DefaultEstimatedCons).FirstOrDefault();
                        }

                        //Se crea objeto para bitacora
                        WorkLog objworkLog = new WorkLog();

                        objworkLog.ChangedBy = auxData.CreatedBy;
                        objworkLog.IdUserWeb = auth.GetUserId(auxData.CreatedBy);

                        if (auxVehicle.Id > 0)
                        {
                            auxVehicle.Modified = DateTimeOffset.Now;
                            auxVehicle.ModifiedBy = auxData.ModifiedBy;
                            _context.Vehicles.Update(auxVehicle);
                            _context.SaveChanges();

                            //datos para bitacora
                            objworkLog.ChangeType = "Actualizado";
                            objworkLog.KeySegment = String.Format("Id: {0}", auxVehicle.Id);
                            objworkLog.DataSource = "BOServicesAPI";
                            objworkLog.NewValues = JsonConvert.SerializeObject(auxVehicle);
                            objworkLog.OriginalValues = JsonConvert.SerializeObject(auxVehicle);
                            objworkLog.ReferenceType = "Vehicles";

                        }
                        else
                        {
                            _context.Vehicles.Add(auxVehicle);
                            _context.SaveChanges();

                            //datos para bitacora
                            objworkLog.ChangeType = "Insertado";
                            objworkLog.KeySegment = "Id: (null)";
                            objworkLog.DataSource = "BOServicesAPI";
                            objworkLog.NewValues = JsonConvert.SerializeObject(auxData);
                            objworkLog.OriginalValues = "El registro se ha creado recientemente";
                            objworkLog.ReferenceType = "Vehicles";

                        }

                        transaction.Commit();

                        //Se inserta en bitacora solo si fue exitoso
                        _workLog.InsertWorkLogData(objworkLog);

                        result.result = 1;
                        result.message = string.Format("Success, idVehicle: {0}", auxVehicle.Id.ToString());
                        return result;
                    }

                    catch (Exception ex)
                    {
                        result.result = 2;
                        result.message = ex.Message + ex.InnerException.Message;
                        transaction.Rollback();
                        return result;
                    }

                }

            }
            else
            {
                return validate;
            }
        }

        /// <summary>
        /// Metodo encargado de obtener el PublicID
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public int getPublicNumber()
        {
            int publicID = 1;
            try
            {
                var vehicles = (from d in _context.Vehicles
                                select d).ToList();

                if (vehicles.Count > 0)
                {
                    var aux = vehicles.Max(x => x.PublicId);
                    publicID = aux + 1;
                }


            }
            catch (Exception)
            {

                throw;
            }

            return publicID;
        }

        /// <summary>
        /// Metodo para validar datos de Vehicle 
        /// </summary>
        /// <param name="auxData"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public Result ValidaNullData(VehicleData auxData)
        {
            Result result = new Result();

            if (string.IsNullOrWhiteSpace(auxData.Plate) || auxData.Plate.Contains("string"))
            {
                result.result = 3;
                result.message = "Datos faltantes, la Placa es obligatoria";
                return result;
            }

            if (string.IsNullOrWhiteSpace(auxData.Vin) || auxData.Vin.Contains("string"))
            {
                result.result = 3;
                result.message = "Datos faltantes, el VIN es obligatorio";
                return result;
            }

            if (string.IsNullOrWhiteSpace(auxData.EcoNumber) || auxData.EcoNumber.Contains("string"))
            {
                result.result = 3;
                result.message = "Datos faltantes, el Eco es obligatorio";
                return result;
            }

            //if (auxData.PublicId <= 0)
            //{
            //    result.result = 3;
            //    result.message = "Datos faltantes, el PublicId es obligatorio";
            //    return result;
            //}

            if (auxData.YearModel <= 0)
            {
                result.result = 3;
                result.message = "Datos faltantes, el YearModel es obligatorio";
                return result;
            }


            if (auxData.VehicleBrandModel <= 0)
            {
                result.result = 3;
                result.message = "Datos faltantes, el VehicleBrandModel es obligatorio";
                return result;
            }


            if (auxData.VehicleClient <= 0)
            {
                result.result = 3;
                result.message = "Datos faltantes, el VehicleClient es obligatorio";
                return result;
            }

            if (auxData.VehicleStatus <= 0)
            {
                result.result = 3;
                result.message = "Datos faltantes, el VehicleStatus es obligatorio";
                return result;
            }

            if (auxData.VehicleVehicleBrand <= 0)
            {
                result.result = 3;
                result.message = "Datos faltantes, el VehicleVehicleBrand es obligatorio";
                return result;
            }

            result.result = 1;
            result.message = "Data correct";
            return result;

        }
    }
}
