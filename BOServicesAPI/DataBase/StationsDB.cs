using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    /// <summary>
    /// Clase para el manejo de base de datos de Estaciones
    /// </summary>
    public class StationsDB
    {
        private readonly OxxoBoContext _context;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="context"></param>
        public StationsDB(OxxoBoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo encargado de obtener un listado de GasStations
        /// </summary>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public List<AuxStations> GetGasStations()
        {
            List<AuxStations> data = new List<AuxStations>();
            try
            {
                data = (from s in _context.GasStations
                        where s.Status == true
                        select new AuxStations
                        {
                            Id = s.Id,
                            OficialName = s.OficialName,
                            NickName = s.NickName,
                            StationNumber = s.StationNumber,
                            Comments = s.Comments,
                            CablesLocationDescription = s.CablesLocationDescription,
                            UserWa = s.UserWa,
                            PassWa = s.PassWa,
                            CgProvider = s.CgProvider,
                            AviVersion = s.AviVersion,
                            CgVersion = s.CgVersion,
                            SgpsVersion = s.SgpsVersion,
                            SgpmVersion =s.SgpmVersion,
                            Diesel = s.Diesel,
                            Magna = s.Magna,
                            Premium = s.Premium,
                            Verified = s.Verified,
                            Service =s.Service,
                            HelpNameEmployee = s.HelpNameEmployee,
                            HelpCommentsTicket = s.HelpCommentsTicket,
                            Iva = s.Iva,
                            IdTotvs = s.IdTotvs,
                            IdSucursalTotvs = s.IdSucursalTotvs,
                            Status = s.Status,
                            SendMailForContingency = s.SendMailForContingency,
                            AccountNumber = s.AccountNumber,
                            ConfigCost =s.ConfigCost,
                            Tardefault = s.Tardefault,
                            CommerceNumber = s.CommerceNumber,
                            LimitCost = s.LimitCost,
                            Autoconsumo = s.Autoconsumo,
                            NotShowInMaps = s.NotShowInMaps,
                            ReadersNozzles = s.ReadersNozzles,
                            CreatedBy = s.CreatedBy,
                            Created =s.Created,
                            ModifiedBy = s.ModifiedBy,
                            Modified = s.Modified,
                            GasStationAddress = s.GasStationAddressNavigation.Id,
                            CatMetodoPagoGasStation = s.CatMetodoPagoGasStationNavigation.Id,
                            FormaDePagoGasStation = s.FormaDePagoGasStationNavigation.Id,
                            GasStationGasStationGroup = s.GasStationGasStationGroupNavigation.Id,
                            ConfiguracionEdGasStation = s.ConfiguracionEdGasStationNavigation.Id,
                            GasStationPcOsVersion = s.GasStationPcOsVersionNavigation.Id,
                            GasStationPumpController = s.GasStationPumpControllerNavigation.Id,
                            PumpTypeGasStation = s.PumpTypeGasStationNavigation.Id,
                            GasStationTimeZoneC = s.GasStationTimeZoneCNavigation.Id,
                            GasStationVolumetric = s.GasStationVolumetricNavigation.Id,
                            GasStationClientGroup = s.GasStationClientGroupNavigation.Id,
                            PlaceId = s.PlaceId,
                            CreId = s.CreId,
                            Bandera = s.Bandera

                        }).OrderBy(m => m.OficialName).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }
    }
}
