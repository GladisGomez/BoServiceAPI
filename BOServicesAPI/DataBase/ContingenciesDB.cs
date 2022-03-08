using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using BOServicesAPI.Entities.CustomizationSticker;
using BOServicesAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    /// <summary>
    /// Clase para el manejo de Contingencias
    /// </summary>
    public class ContingenciesDB
    {
        private readonly OxxoBoContext _context;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context"></param>
        public ContingenciesDB(OxxoBoContext context)
        {
           
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de contingencias dependiendo el valor que reciba como tipo
        /// </summary>
        /// <param name="TypeContingency"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxContingencies> GetContingenciesByType(int TypeContingency)
        {
            List<AuxContingencies> data = new List<AuxContingencies>();
            try
            {
                data = (from c in _context.ContingencySet
                        where c.ContingencyStatusContingencyNavigation.Id == TypeContingency
                        select new AuxContingencies
                        {
                            Id = c.Id,
                            Code = c.Code,
                            DateTimeContingency = c.DateTimeContingency,
                            NumberTransaction = c.NumberTransaction,
                            NumberPump = c.NumberPump,
                            Quantity = c.Quantity,
                            Amount = c.Amount,
                            QuantityReal = c.QuantityReal,
                            AmountReal = c.AmountReal,
                            NameDispatcher = c.NameDispatcher,
                            MessageError =c.MessageError,
                            Comments = c.Comments,
                            DateFinishFinanzas = c.DateFinishFinanzas,
                            PathInvoice = c.PathInvoice,
                            NcontrolGas = c.NcontrolGas,
                            DateFinishAtcnoc = c.DateFinishAtcnoc,
                            PriceUnit = c.PriceUnit,
                            ParentId = c.ParentId,
                            CommentsCancel = c.CommentsCancel,
                            WithInternet = c.WithInternet,
                            DatetimeStamp = c.DatetimeStamp,
                            Used = c.Used,
                            Odometer = c.Odometer,
                            TypeContingency = c.TypeContingency,
                            CreatedBy = c.CreatedBy,
                            Created = c.Created,
                            ModifiedBy = c.ModifiedBy,
                            Modified = c.Modified,
                            ContingencyClientGroup = c.ContingencyClientGroupNavigation.Id,
                            ContingencyDriver = c.ContingencyDriverNavigation.Id,
                            ContingencyEmployee = c.ContingencyEmployeeNavigation.Id,
                            ContingencyEmployee1 = c.ContingencyEmployee1Navigation.Id,
                            ContingencyFuelType = c.ContingencyFuelTypeNavigation.Id,
                            ContingencyGasStation = c.ContingencyGasStationNavigation.Id,
                            ContingencyStatusContingency = c.ContingencyStatusContingencyNavigation.Id,
                            ContingencyTypeContigency = c.ContingencyTypeContigencyNavigation.Id,
                            ContingencyVehicle = c.ContingencyVehicleNavigation.Id
                        }).OrderBy(m => m.Created).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de contingencias dependiendo el cliente
        /// </summary>
        /// <param name="idClient"></param>
        /// <param name="typeContingency"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxContingencies> GetContingenciesByClientAndTypeContingency(int idClient,int typeContingency)
        {
            List<AuxContingencies> data = new List<AuxContingencies>();
            try
            {
                data = (from c in _context.ContingencySet
                        where c.ContingencyClientGroupNavigation.Id == idClient
                         && c.ContingencyTypeContigencyNavigation.Id == typeContingency
                        select new AuxContingencies
                        {
                            Id = c.Id,
                            Code = c.Code,
                            DateTimeContingency = c.DateTimeContingency,
                            NumberTransaction = c.NumberTransaction,
                            NumberPump = c.NumberPump,
                            Quantity = c.Quantity,
                            Amount = c.Amount,
                            QuantityReal = c.QuantityReal,
                            AmountReal = c.AmountReal,
                            NameDispatcher = c.NameDispatcher,
                            MessageError = c.MessageError,
                            Comments = c.Comments,
                            DateFinishFinanzas = c.DateFinishFinanzas,
                            PathInvoice = c.PathInvoice,
                            NcontrolGas = c.NcontrolGas,
                            DateFinishAtcnoc = c.DateFinishAtcnoc,
                            PriceUnit = c.PriceUnit,
                            ParentId = c.ParentId,
                            CommentsCancel = c.CommentsCancel,
                            WithInternet = c.WithInternet,
                            DatetimeStamp = c.DatetimeStamp,
                            Used = c.Used,
                            Odometer = c.Odometer,
                            TypeContingency = c.TypeContingency,
                            CreatedBy = c.CreatedBy,
                            Created = c.Created,
                            ModifiedBy = c.ModifiedBy,
                            Modified = c.Modified,
                            ContingencyClientGroup = c.ContingencyClientGroupNavigation.Id,
                            ContingencyDriver = c.ContingencyDriverNavigation.Id,
                            ContingencyEmployee = c.ContingencyEmployeeNavigation.Id,
                            ContingencyEmployee1 = c.ContingencyEmployee1Navigation.Id,
                            ContingencyFuelType = c.ContingencyFuelTypeNavigation.Id,
                            ContingencyGasStation = c.ContingencyGasStationNavigation.Id,
                            ContingencyStatusContingency = c.ContingencyStatusContingencyNavigation.Id,
                            ContingencyTypeContigency = c.ContingencyTypeContigencyNavigation.Id,
                            ContingencyVehicle = c.ContingencyVehicleNavigation.Id
                        }).OrderBy(m => m.Created).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }


        /// <summary>
        /// Metodo encargado de obtener una lista de contingencias dependiendo el valor que reciba como tipo
        /// </summary>
        /// <param name="idStation"></param>
        /// <param name="typeContingency"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxContingencies> GetContingenciesByStationAndTypeContingency(int idStation, int typeContingency)
        {
            List<AuxContingencies> data = new List<AuxContingencies>();
            try
            {              
                data = (from c in _context.ContingencySet
                        where c.ContingencyGasStationNavigation.Id == idStation 
                        && c.ContingencyTypeContigencyNavigation.Id == typeContingency
                        select new AuxContingencies
                        {
                            Id = c.Id,
                            Code = c.Code,
                            DateTimeContingency = c.DateTimeContingency,
                            NumberTransaction = c.NumberTransaction,
                            NumberPump = c.NumberPump,
                            Quantity = c.Quantity,
                            Amount = c.Amount,
                            QuantityReal = c.QuantityReal,
                            AmountReal = c.AmountReal,
                            NameDispatcher = c.NameDispatcher,
                            MessageError = c.MessageError,
                            Comments = c.Comments,
                            DateFinishFinanzas = c.DateFinishFinanzas,
                            PathInvoice = c.PathInvoice,
                            NcontrolGas = c.NcontrolGas,
                            DateFinishAtcnoc = c.DateFinishAtcnoc,
                            PriceUnit = c.PriceUnit,
                            ParentId = c.ParentId,
                            CommentsCancel = c.CommentsCancel,
                            WithInternet = c.WithInternet,
                            DatetimeStamp = c.DatetimeStamp,
                            Used = c.Used,
                            Odometer = c.Odometer,
                            TypeContingency = c.TypeContingency,
                            CreatedBy = c.CreatedBy,
                            Created = c.Created,
                            ModifiedBy = c.ModifiedBy,
                            Modified = c.Modified,
                            ContingencyClientGroup = c.ContingencyClientGroupNavigation.Id,
                            ContingencyDriver = c.ContingencyDriverNavigation.Id,
                            ContingencyEmployee = c.ContingencyEmployeeNavigation.Id,
                            ContingencyEmployee1 = c.ContingencyEmployee1Navigation.Id,
                            ContingencyFuelType = c.ContingencyFuelTypeNavigation.Id,
                            ContingencyGasStation = c.ContingencyGasStationNavigation.Id,
                            ContingencyStatusContingency = c.ContingencyStatusContingencyNavigation.Id,
                            ContingencyTypeContigency = c.ContingencyTypeContigencyNavigation.Id,
                            ContingencyVehicle = c.ContingencyVehicleNavigation.Id
                        }).OrderBy(m => m.Created).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        /// <summary>
        /// Metodo encargado de insertar una contingencia en base de datos
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public Result InsertContingencyData(AuxContingencies auxData)
        {
            Result result = new Result();

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    ContingencySet data = new ContingencySet()
                    {
                       
                        CreatedBy = auxData.CreatedBy,
                        Created = DateTimeOffset.Now
                    };



                    _context.ContingencySet.Add(data);
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
