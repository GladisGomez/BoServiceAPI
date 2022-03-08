using BOServicesAPI.BusinessLogic.CustomizationStiker;
using BOServicesAPI.DataBase;
using BOServicesAPI.DBContext;
using BOServicesAPI.EncryptBO;
using BOServicesAPI.Entities;
using BOServicesAPI.Entities.CustomizationSticker;
using BOServicesAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BOServicesAPI.BusinessLogic.CustomizationSticker
{

    public class Customization
    {
        private readonly IConfiguration _configuration;
        private readonly OxxoBoContext _context;
        private CustomStickersDB _customStickers;
        private CustomStickersTrakingDB _customStickersTrakingDB;
        private StoreProcedureDB _storeProcedureDB;
        private string _keyAES256;
        private string _keyAES256GOSMO;
        private AuthDB _AuthDB;
        private string _IdEmployeesAppSticker;
        private string _UIDSize;
        private string _sizeTank;



        public Customization(OxxoBoContext context, IConfiguration configuration)
        {
            var xxx = configuration["ConnectionStrings:DefaultConnection"];
            _context = context;
            _customStickers = new CustomStickersDB(_context);
            _customStickersTrakingDB = new CustomStickersTrakingDB(_context);
            _storeProcedureDB = new StoreProcedureDB(configuration["ConnectionStrings:DefaultConnection"]);
            _configuration = configuration;
            _keyAES256= _configuration["GlobalParameters:KeyAES256"];
            _keyAES256GOSMO = _configuration["GlobalParameters:KeyAES256GOSMO"];
            _IdEmployeesAppSticker = _configuration["GlobalParameters:IdEmployeesAppSticker"];
            _UIDSize= _configuration["GlobalParameters:UIDSize"];
            _sizeTank= _configuration["GlobalParameters:sizeTank"];
            _AuthDB = new AuthDB(_context);
        }

        public List<string> GenerationCustomStiker(GenerationCustomStikerDtos generationCustomStikerDtos)
        {
            List<string> sidEncript = new List<string>();
            List<string> sidS = new List<string>();
            EncryptionAES256 encryptionAES256 = new EncryptionAES256(_keyAES256, _keyAES256GOSMO);
            GenerationSid generationSid = new GenerationSid();            
            int number = generationCustomStikerDtos.Sidnumber;

            try
            {                 
                int flag = 1;
                string usuario = _AuthDB.UserExist(generationCustomStikerDtos.IdUserWebSet);
                if (String.IsNullOrEmpty(usuario))
                {
                   // result.result = 2; result.message = "No existe el usuario";
                    return null;
                }            
                while (flag == 1)
                {
                    List<string> sid = new List<string>();
                    for (int i = 0; i < number; i++)                    
                        sid.Add(encryptionAES256.Encryption(generationSid.NewSid().Trim(), 2));

                    sid = sid.Distinct().ToList();

                    var sidSExis=_customStickers.getCustomStickersList(sid);
                   
                    sidS.AddRange(sid.Where(p => !sidSExis.Any(p2 => p2 == p)));
                    
                    if (sidS.Count== generationCustomStikerDtos.Sidnumber)                   
                        flag = 0;                    
                    else
                        number = generationCustomStikerDtos.Sidnumber - sidS.Count;                  
                }

                foreach (var sidGenerado in sidS)
                {
                    CustomStickers customStickers = new CustomStickers();
                    string sEncryp = encryptionAES256.Encryption(encryptionAES256.Decryption(sidGenerado, 2), 1);//opcion 1 :para la key de generacion sid
                    sidEncript.Add(sEncryp);
                    customStickers.CustomStickerCatCustomStickersStatus = 1;
                    customStickers.Sid = sidGenerado;
                   // customStickers.Sid = encryptionAES256.Decryption(sidGenerado, 2);
                    customStickers.Sidpers = sEncryp;
                    customStickers.Created = DateTime.Now;
                    customStickers.CreatedBy = usuario;
                    customStickers.CustomStickerUserWeb = generationCustomStikerDtos.IdUserWebSet;//agregar campo de id usuario 
                    var res = _customStickers.AddCustomStickers(customStickers, traking(customStickers,"Insert"));
                }
                           
            }catch(Exception ex) {
                throw new Exception(ex.Message);
            }
            return sidEncript;
        }

        public CustomStickersTrakings traking(CustomStickers customStickers, string operation)
        {
            return new CustomStickersTrakings()
            {
                CreatedBy = customStickers.CreatedBy,
                Created = customStickers.Created,
                CustomStickersTrakingCustomSticker = customStickers.Id,
                CustomStickersTrakingCatCustomStickersStatus = customStickers.CustomStickerCatCustomStickersStatus,
                Sid = customStickers.Sid,
                Sidpers = customStickers.Sidpers,
                Uid = customStickers.Uid,
                CatalogNumber = customStickers.CatalogNumber,
                Po = customStickers.Po,
                Operation= operation,
                CustomStickersTrakingTag = customStickers.CustomStickerTag,
                CustomStickersTrakingCatCustomStickersModel = customStickers.CustomStickerCatCustomStickersModel,
                CustomStickersTrakingUserWeb = customStickers.CustomStickerUserWeb,
                Lot=customStickers.Lot
            };

        }


        public  List<string> SendToSupplierCustomSticker(SendToSupplierDtos  sendToSupplierDtos){

            List<string> result = new List<string>();
            List<CustomStickersTrakings> trakings = new List<CustomStickersTrakings>();

            string usuario = _AuthDB.UserExist(sendToSupplierDtos.IdUserWebSet);
            if (String.IsNullOrEmpty(usuario))
            {
                // result.result = 2; result.message = "No existe el usuario";
                return null;
            }

            var listCustomStiker = _customStickers.listCustomStickers(1, sendToSupplierDtos.numberSids);               

            foreach (var ex in listCustomStiker){
                ex.CustomStickerCatCustomStickersStatus = 2;
                ex.Modified = DateTime.Now;
                ex.ModifiedBy = usuario;
                ex.CustomStickerUserWeb = sendToSupplierDtos.IdUserWebSet;
                ex.CustomStickerCatCustomStickersModel = sendToSupplierDtos.idModel;
                var trac = traking(ex, "Update");
                trac.CustomStickersTrakingCustomSticker = ex.Id;
                trakings.Add(trac);
            }
           var resultUpdate=  _customStickers.updateCustomStickers(listCustomStiker);
            if (resultUpdate){
                _customStickersTrakingDB.AddRangecustomStickers(trakings);
            }

            return listCustomStiker.Select(x=>x.Sidpers).ToList();
        }

        

        public ResultData<UIDAssignmentResult> UIDAssignmentCustomSticker(Assignment uIDAssignment)
        {         
         
            List<UIDAssignmentDtos> datosArchivo = new List<UIDAssignmentDtos>();
            List <CustomStickers> datosDB = new List<CustomStickers>();
            ResultData<UIDAssignmentResult> result = new ResultData<UIDAssignmentResult>() { Data=  new UIDAssignmentResult() {  Notsignment=new List<string>() }, result=new Result() {  result=1} };
            try
            {
                string usuario = _AuthDB.UserExist(uIDAssignment.IdUserWebSet);
                if (String.IsNullOrEmpty(usuario))
                {
                    // result.result = 2; result.message = "No existe el usuario";
                    return null;
                }

                var resultData = readFileUID(uIDAssignment.urlFile);
                datosArchivo = resultData.Data;
                //Cuando el archivo no contiene el estructura esperada 
                if (resultData.result.result != 1)
                {
                    result.result = resultData.result;
                    return result;
                }
                
                if (datosArchivo.Count != 0)
                {
                    //datos duplicados UID
                    var uidDuplicados = datosArchivo.GroupBy(x => x.UID).Where(x => x.Count() > 1).Select(x => x).ToList();
                    if (uidDuplicados.Count != 0){
                        result.Data.Notsignment.AddRange(uidDuplicados.Select(x => x.Key));
                        result.result.result = 3;
                        result.result.message = "UIDs Duplicados";
                        return result;
                    }
                    //Datos duplicados SID
                    var uidSidDuplicados = datosArchivo.GroupBy(x => x.SIDPers).Where(x => x.Count() > 1).Select(x => x).ToList();
                    if (uidSidDuplicados.Count != 0)
                    {
                        result.Data.Notsignment.AddRange(uidSidDuplicados.Select(x => x.Key));
                        result.result.result = 3;
                        result.result.message = "SIDs Duplicados";
                        return result;
                    }

                    //Datos vacios
                    var datosBlancos = datosArchivo.Where(x=>String.IsNullOrEmpty(x.SIDPers)||String.IsNullOrEmpty(x.UID) ||String.IsNullOrEmpty(x.PO) || String.IsNullOrEmpty(x.Lot) || String.IsNullOrEmpty(x.CatalogNumber) ).ToList();
                    if (datosBlancos.Count != 0)
                    {
                        result.Data.Notsignment.AddRange(datosBlancos.Select( x=>x.PO+","+x.CatalogNumber+","+x.SIDPers+","+x.UID+","+x.Barcode+","+x.Lot ));
                        result.result.result = 3;
                        result.result.message = "Los datos son requeridos";
                        return result;
                    }

                    //Lotes
                    var lotes= datosArchivo.GroupBy(x => x.Lot).Select(x => x).ToList();
                    bool flLotes = false;
                    foreach (var lote in lotes)
                    {
                        if (lote.Count() != 100)
                        {
                            result.Data.Notsignment.Add(lote.Key);
                            flLotes = true;

                        }
                    }
                    if (flLotes)
                    {
                        result.result.result = 3;
                        result.result.message = "Los lotes no cumplen con 100 requeridos";
                        return result;
                    }

                    if (result.result.result==1) {
                        //
                        var repuesta = _customStickers.getListCustomSticker(datosArchivo.Select(x => x.SIDPers).ToList());

                        if (repuesta.Count == 0 || repuesta.Count!= datosArchivo.Count()) {
                            result.Data.Notsignment.AddRange(datosArchivo.Where(t => !repuesta.Any(x => x.Sidpers == t.SIDPers)).Select(z => z.SIDPers).ToList());

                            result.result.result = 2;
                            result.result.message = "No se encontraron registros de los Sids:";

                        }
                        else
                        {
                            var uidRespuesta = _customStickers.getListCustomStickerUID(datosArchivo.Select(y => y.UID).ToList());
                            if (uidRespuesta.Count == 0)
                            {

                                result = UIDAssignment(datosArchivo, repuesta, usuario, uIDAssignment.IdUserWebSet);
                            }
                            else
                            {
                               
                                result.Data.Notsignment.AddRange(uidRespuesta.Where(t => uidRespuesta.Any(x => x.Uid == t.Uid)).Select(z => z.Uid).Distinct().ToList());

                                result.result.result = 2;
                                result.result.message = "Los UIDs se encuentran asignados";
                            }

                        }
                    }
                }                                       

            }
            catch (Exception ex){
                string msg = ex.Message;
            }
            return result;
        }

        private ResultData<List<UIDAssignmentDtos>> readFileUID(string url)
        {
            ResultData<List<UIDAssignmentDtos>> datosArchivo =new ResultData<List<UIDAssignmentDtos>>() {  Data=new List<UIDAssignmentDtos>(), result=new Result() { result=1 } };
            EncryptionAES256 encryptionAES256 = new EncryptionAES256(_keyAES256, _keyAES256GOSMO);
            string line = String.Empty;
            List<string> uidsPlanos = new List<string>();

            if (File.Exists(url))
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(url);
                if (!url.ToUpper().Contains(".TXT" )&&!url.ToUpper().Contains(".CSV"))
                {
                    datosArchivo.result.result = 2;
                    datosArchivo.result.message = "Extensión no valida, se espera un archivo .txt o .csv ";
                    return datosArchivo;
                }
                //Read the first line of text
                //Validar el encabezado
                try
                {
                    line = sr.ReadLine();
                    line.Trim();
                    string[] liniaEncabezado = line.Split(',');
                    if (liniaEncabezado.Length != 6 || "PO" != liniaEncabezado[0] || "CatalogNumber" != liniaEncabezado[1] || "DATA" != liniaEncabezado[2] || "UID" != liniaEncabezado[3] || "Barcode" != liniaEncabezado[4] || "Lot" != liniaEncabezado[5])
                    {
                        sr.Close();
                        datosArchivo.result.result = 2; datosArchivo.result.message = "La carga no se realizó, El fichero no contiene encabezados : PO,CatalogNumber,DATA,UID,Barcode,Lot ";
                        return datosArchivo;
                    }
                }
                catch (Exception ex)
                {
                    sr.Close();
                    datosArchivo.result.result = 2; datosArchivo.result.message = "La carga no se realizó, El fichero no contiene encabezados : PO,CatalogNumber,DATA,UID,Barcode,Lot ";
                    return datosArchivo;
                }
               
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //Read the next line
                    line.Trim();
                    string[] linia = line.Split(',');
                    if (linia.Length == 6)
                    {
                        uidsPlanos.Add(linia[3]);
                        datosArchivo.Data.Add(new UIDAssignmentDtos() { PO = linia[0], CatalogNumber = linia[1], SIDPers = linia[2], UID = encryptionAES256.Encryption(linia[3], 2), Barcode = String.IsNullOrEmpty(linia[4]) ? 0 : Convert.ToInt64(linia[4]), Lot = linia[5] });
                    }
                    else
                    {
                        datosArchivo.result.result = 2;
                        var auxli = string.Join("", linia); 
                        if (String.IsNullOrEmpty(auxli))
                        {                            
                            datosArchivo.result.message = "El archivo contine linias en blanco.";
                        }
                        else
                        {
                            datosArchivo.result.message = "Es requerido agregar la información con la siguiente nomenclatura PO,CatalogNumber,DATA,UID,Barcode,Lot ";

                        }
                    }
                    line = sr.ReadLine();
                }

                if (datosArchivo.Data.Count == 0)
                {
                    datosArchivo.result.result = 2;
                    datosArchivo.result.message = "El archivo no contiene información";
                }
                else
                {

                    var notZise = uidsPlanos.Where(x => x.Length !=Convert.ToInt64(_UIDSize));
                    if (notZise.Count() != 0)
                    {
                        datosArchivo.result.result = 2;
                        datosArchivo.result.message = "Los UID no cumplen con el tamaño aceptado: " + String.Join(",", notZise);
                    }
                }

                sr.Close();//close the file
            }
            else
            {
                datosArchivo.result.result = 2;
                datosArchivo.result.message = "El archivo no existe";
            }
            return datosArchivo;
        }


        private List<InitialCharge> readFileInitial(string url)
        {
            List<InitialCharge> datosArchivo = new List<InitialCharge>();
            EncryptionAES256 encryptionAES256 = new EncryptionAES256(_keyAES256, _keyAES256GOSMO);
            string line = String.Empty;
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(url);
            //Read the first line of text
            line = sr.ReadLine();
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //Read the next line
                line.Trim();
                string[] linia = line.Split(',');
                if (linia.Length == 2)
                {
                    datosArchivo.Add(new InitialCharge() { SID = encryptionAES256.Encryption(linia[0], 2), SIDPers = linia[1] });
                }
                line = sr.ReadLine();
            }
            sr.Close();//close the file
            return datosArchivo;
        }


        private List<MassiveVehicleAssignmentDtos> readFileMassiveVehicleAssignment(string url)
        {
            List<MassiveVehicleAssignmentDtos> datosArchivo = new List<MassiveVehicleAssignmentDtos>();
           // EncryptionAES256 encryptionAES256 = new EncryptionAES256(_keyAES256, _keyAES256GOSMO);
            string line = String.Empty;
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(url);
            //Read the first line of text
            line = sr.ReadLine();
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //Read the next line
                line.Trim();
                string[] linia = line.Split(',');
                if (linia.Length == 2)
                {
                    //encryptionAES256.Encryption(linia[0], 2)
                    datosArchivo.Add(new MassiveVehicleAssignmentDtos() {  UID = linia[0], plates= linia[1] });
                }
                line = sr.ReadLine();
            }
            sr.Close();//close the file
            return datosArchivo;
        }

        private ResultData<UIDAssignmentResult> UIDAssignment(List<UIDAssignmentDtos> datosArchivo, List<CustomStickers> datosDB, string nameUser, int user ) {


            ResultData<UIDAssignmentResult> result = new ResultData<UIDAssignmentResult>() {Data=new UIDAssignmentResult(), result=new Result()};
            try
            {
                List<CustomStickersTrakings> listTraking = new List<CustomStickersTrakings>();
                foreach(var dato in datosDB)
                {
                    var cambioDato = datosArchivo.Where(x => x.SIDPers == dato.Sidpers).FirstOrDefault();
                    dato.Modified = DateTime.Now;
                    dato.ModifiedBy = nameUser;
                    dato.CustomStickerUserWeb = user;
                    dato.CustomStickerCatCustomStickersStatus = 5;                  
                    dato.Uid = cambioDato.UID;
                    dato.Po = cambioDato.PO;
                    dato.CatalogNumber = cambioDato.CatalogNumber;
                    dato.Lot = cambioDato.Lot;
                    listTraking.Add(traking(dato, "Update"));
                    //if (resultBD == false)
                    //{
                    //    result.Data.UIDsNotsignment.Add(dato.Sidpers);
                    //}
                    //else
                    //{
                    // result.UIDsNotsignment.Add( new dato.Sidpers);
                    //}                  
                }
                var resultBD = _customStickers.UpdatecustomStickerList(datosDB, listTraking);
                if (resultBD)
                {
                    result.result.result = 1; result.result.message = "Archivo procesado correctamete";
                }
                //var notfout = datosArchivo.Where(x => !datosDB.Any(y => y.Sidpers == x.SIDPers)).ToList();
                //result.UIDsNotsignment.AddRange(notfout.Select(y => y.SIDPers).ToList());
            }
            catch(Exception ex)
            {
                result.result.result = 2;   result.result.message = ex.Message;
            }
            return result;

        }
        public ResultData<List<MassiveVehicleAssignmentResult>> MassiveVehicleAssignmentCustomSticker(Assignment Assignment)
        {
            ResultData<List<MassiveVehicleAssignmentResult>> ListResult = new ResultData<List<MassiveVehicleAssignmentResult>>();
            try
            {
                var validate = VehicleAssignmentEntryValidation(Assignment.IdUserWebSet);
                
                if (validate.result != 1)
                {
                    ListResult.result = validate;
                    return ListResult;
                }
                var listFromFile = readFileMassiveVehicleAssignment(Assignment.urlFile);
                if (listFromFile == null)
                {
                    ListResult.result.result = 3;   ListResult.result.message = "El archivo esta vacio no es posible realizar asignacion de vehiculo " ;
                    return ListResult;
                }
                var lisNodata = listFromFile.Where(x => String.IsNullOrEmpty(x.plates)|| String.IsNullOrEmpty(x.UID)).ToList();
                
                if (lisNodata.Count() != 0)
                {
                    ListResult.Data.AddRange(lisNodata.Select(y => new MassiveVehicleAssignmentResult() { UID = y.UID, plates = y.plates, result=3, message="Son requeridos los datos de placas y uid " }).ToList());
                    foreach (var Nodata in lisNodata)
                        listFromFile.Remove(Nodata);
                }

                var ListVehicle = _customStickers.getListVehicle(lisNodata.Select(x => x.plates).ToList());
                //datos que  tienen vehiculos asignados
                var vehicleFound = listFromFile.Where(t => ListVehicle.Any(x => x.Plate == t.plates)).Select( z=> new MassiveVehicleAssignmentDtos() {  plates=z.plates, idVehicle=z.idVehicle, UID=z.UID }).ToList();

                var vehicleNotFound = listFromFile.Where(t => !ListVehicle.Any(x => x.Plate == t.plates)).ToList();
                if (vehicleNotFound.Count() != 0)
                {
                    var resnotFout = vehicleNotFound.Select(z => new MassiveVehicleAssignmentResult() { UID = z.UID, plates = z.plates, result = 2, message = "El vehículo no está dado de alta." }).ToList();
                    ListResult.Data.AddRange(resnotFout);
                }

                foreach (var fromFilr in vehicleFound)
                {
                    var resultResp = vehicleAssignment( new VehicleAssignmentDtos() { IdUserWebSet= Assignment.IdUserWebSet, idVehicle=fromFilr.idVehicle, UID=fromFilr.UID}, validate.message);
                    ListResult.Data.Add(new MassiveVehicleAssignmentResult (){ plates=fromFilr.plates, UID=fromFilr.UID, result=resultResp.result, message=fromFilr.message });
                }                

            }
            catch (Exception ex)
            {
                ListResult.result.result = 2;
                ListResult.result.message = ex.Message;
            }
            return ListResult;
        }

        //public List<MassiveVehicleAssignmentResult> MassiveVehicleAssignment(List<MassiveVehicleAssignmentDtos>  listFile)
        //{
        //    //buscar id  de Vehiculo exista
        //    //var 

        //    //buscar sticker que no tenga asignados vehiculo

        //    //realizar update 


        //}


        public Result vehicleAssignmentCustomSticker(VehicleAssignmentDtos vehicleAssignmentDtos)
        {
            Result result = new Result();

            try
            {
                if (vehicleAssignmentDtos.idVehicle == 0)
                {
                    result.result = 3; result.message = "El vehículo no es valido.";
                    return result;
                }
                else
                {
                    if (vehicleAssignmentDtos.IdUserWebSet == 0)
                    {
                        result.result = 3; result.message = "El usuario no es valido.";
                        return result;
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(vehicleAssignmentDtos.UID))
                        {
                            result.result = 3; result.message = "El sticker no es valido.";
                            return result;

                        }
                    }
                }
          

            
                var validate = VehicleAssignmentEntryValidation(vehicleAssignmentDtos.IdUserWebSet);
                if (validate.result == 1)
                {
                    result = vehicleAssignment(vehicleAssignmentDtos, validate.message);
                } 
             
                // _customStickers
                
                

            }
            catch (Exception ex)
            {
                result.result = 2;
                result.message = ex.Message;
            }
            return result;
        }

        public Result VehicleAssignmentEntryValidation(int IdUserWebSet) {
            Result result = new Result() ;

          
            if (String.IsNullOrEmpty(_IdEmployeesAppSticker) || _IdEmployeesAppSticker == "0")
            {
                result.result = 3; result.message = "IdEmployee es requerido con un dato valido en el archivo de configuración";
                return result;
            }            

            return ValidateUser(IdUserWebSet);

        }
        public Clients validarUserCliente(int IdUserWebSet, int idVehiculo)
        {
            try
            {
                var data = (from c in _context.Clients
                            join cl in _context.ClientGroups on c.ClientGroupClientNavigation.Id equals cl.Id
                            join v in _context.Vehicles on c.Id equals v.VehicleClientNavigation.Id
                            join clg in _context.UsersInClientGroupSet on cl.Id equals clg.UsersInClientGroupClientGroupNavigation.Id
                            join us in _context.UserWebSet on clg.UsersInClientGroupUserWebNavigation.Id equals us.Id
                            //join tag in _context.Tags on v.Id equals tag.TagVehicleNavigation.Id into TagVehicles
                            //from tagV in TagVehicles.DefaultIfEmpty()
                            where us.Id == IdUserWebSet && cl.Status == 1 && c.Status == 1 && v.Id == idVehiculo
                            select new Clients
                            {
                                Id = c.Id,
                                NickName = c.NickName
                            }).FirstOrDefault();

                return data;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public Result ValidateUser(int IdUserWebSet)
        {
            Result result = new Result();
            int idEmployees = Convert.ToInt32(_IdEmployeesAppSticker);

            string usuario = _AuthDB.UserExist(IdUserWebSet);
            if (String.IsNullOrEmpty(usuario))
            {
                result.result = 2; result.message = "No existe el usuario";

            }
            else
            {
                result.result = 1; result.message = usuario;
            }

            return result;
        }


        public Result vehicleAssignment(VehicleAssignmentDtos vehicleAssignmentDtos, string usuario)
        {
            CustomStickers customStickers = new CustomStickers();
            TankVehiclesSet tankVehiclesSet = new TankVehiclesSet();
            Vehicles vehicle = new Vehicles();
            Result result = new Result();
            EncryptionAES256 encryptionAES256 = new EncryptionAES256(_keyAES256, _keyAES256GOSMO);
            

            tankVehiclesSet = _customStickers.GetTank(vehicleAssignmentDtos.idVehicle);
            if (tankVehiclesSet.Id == 0)
            {
                
                if (String.IsNullOrEmpty(_sizeTank))
                {
                    //No existe registro de UID
                    result.result = 2;
                    result.message = "Es necesario agregar el el tamaño del tanque en las configuraciones de la Api.";
                }
                else
                {
                    tankVehiclesSet.VehicleTankVehicles = vehicleAssignmentDtos.idVehicle;
                    tankVehiclesSet.TankVehiclesTankIdentifier = 3;
                    tankVehiclesSet.Created = DateTime.Now;
                    tankVehiclesSet.CreatedBy = usuario;
                    tankVehiclesSet.Modified = DateTime.Now;
                    tankVehiclesSet.ModifiedBy= usuario;
                    tankVehiclesSet.CapacityTank = Convert.ToInt64(_sizeTank);
                }
                
            }
            customStickers = _customStickers.GetCustomStickersxUID(encryptionAES256.Encryption(vehicleAssignmentDtos.UID, 2));
            if (customStickers == null)
            {
                //No existe registro de UID
                result.result = 2;
                result.message = "El Sticker no está dado de alta.";
            }
            else
            {
                if (customStickers.CustomStickerTag == null)
                {
                    vehicle = _customStickers.GetVehiclexID(vehicleAssignmentDtos.idVehicle);
                    if (vehicle == null)
                    {
                        //No existe El Vehículo
                        result.result = 2;
                        result.message = "El vehículo no está dado de alta";
                    }
                    else
                    {
                        var usersVehi = validarUserCliente(vehicleAssignmentDtos.IdUserWebSet, vehicleAssignmentDtos.idVehicle);
                        if (usersVehi == null)
                        {
                            result.result = 3; result.message = "El usuario no tiene permiso sobre el vehículo";
                            return result;
                        }
                        var sid = vehicleAssignmentDtos.UID + '|' + customStickers.Sidpers;
                        customStickers.CustomStickerCatCustomStickersStatus = 12;
                        customStickers.ModifiedBy = usuario;
                        customStickers.Modified = DateTime.Now;
                        customStickers.CustomStickerUserWeb = vehicleAssignmentDtos.IdUserWebSet;

                        var dateInserUpdate = DateTime.Now;
                        Tags tags = new Tags()
                        {
                            Sid = sid,
                            Uid = vehicleAssignmentDtos.UID,
                            CreatedBy = usuario,
                            Active = true,
                            ServiceDataTime = dateInserUpdate,
                            ActivationDateTime = dateInserUpdate,
                            ESid = EncryptESID(sid).ESID,
                            TagReplacementReason = 71,
                            TagTagType = 1003,
                            TagTankIdentifier = tankVehiclesSet.TankVehiclesTankIdentifier,
                            TagTreatmentType = 1,
                            TagVehicle = vehicleAssignmentDtos.idVehicle,
                            TagEmployee = 1184,
                            Created = dateInserUpdate,
                            ModifiedBy = usuario,
                            Modified= dateInserUpdate

                        };

                        var resul = _customStickers.AddCustomStickerAndTags(customStickers, tags, tankVehiclesSet);
                        if (String.IsNullOrEmpty(resul))
                        {
                            //Correcto
                            result.result = 1;
                            result.message = "Vehículo  asignado correctamente";
                        }
                        else
                        {
                            result.result = 2;
                            result.message = resul;
                        }
                    }
                }
                else
                {
                    result.result = 2;
                    result.message = "El sticker ya fue asignado a un Vehículo";
                    //El sticker ya fue asignado a un vehiculo
                }
            }
            return result;

        }
        public TagEncrypt EncryptESID(string sid)
        {
            TagEncrypt result = new TagEncrypt();
            var TdAu = new GngTripleDesAutorizador();
            result.TagOk = true;
            result.ESID = TdAu.EncryptData(sid);
            return result;
        }

        public string DencryptESID(string sid)
        {
            string result = string.Empty;
            var TdAu = new GngTripleDesAutorizador();
            result = TdAu.DecryptData(sid);
            return result;
        }

        public Result ValidateAssignment(Assignment assignment)
        {
            Result result = new Result(){ result=1 };
            if (String.IsNullOrEmpty(assignment.urlFile)|| assignment.IdUserWebSet == 0)
            {
                result.result = 3;
                result.message = "Los datos de entrada son requeridos.";
            }
            else
            {
                string usuario = _AuthDB.UserExist(assignment.IdUserWebSet);
                if (String.IsNullOrEmpty(usuario))
                {
                    result.result = 2; result.message = "No existe el usuario";

                }
                else
                {
                    result.result = 1; result.message = usuario;
                }
            }
            return result;

        }

        #region Precarga       
        //public Result InitialChargeCustomSticker(Assignment assignment)
        //{
        //    Result result = new Result();
        //    try
        //    {
        //        result = ValidateAssignment(assignment);
        //        if (result.result==1)
        //        {
        //           var listSidInitial = readFileInitial(assignment.urlFile);
        //            if (listSidInitial != null)
        //            {
        //                foreach(var sid in listSidInitial)
        //                {
        //                    CustomStickers customStickers = new CustomStickers();
        //                    customStickers.CustomStickerCatCustomStickersStatus = 1;
        //                    customStickers.Sid = sid.SID;
        //                    customStickers.Sidpers = sid.SIDPers;
        //                    customStickers.Created = DateTime.Now;
        //                    customStickers.CreatedBy = result.message;
        //                    customStickers.CustomStickerUserWeb = assignment.IdUserWebSet;//agregar campo de id usuario 
        //                    var res = _customStickers.AddCustomStickers(customStickers, traking(customStickers, "Insert"));
        //                }
        //                result.result = 1; result.message = "Se agregaron Todos los sid";
        //            }
        //            else
        //            {
        //                result.result = 3; result.message = "Sin datos en el archivo";
        //            }
        //        }


        //    }catch(Exception ex)
        //    {
        //       // result.result = 3; result.message = "Sin datos en el archivo";
        //        throw new Exception(ex.Message);
        //    }

        //    return result;
        //}

        public string GenerationXMLStickers(List<InitialCharge> initialCharges, string users)
        {
            //List<DirectorioPsiUvDto> listaPsiUv = new List<DirectorioPsiUvDto>();

            string xmlEstado = String.Empty;

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = true;

            if (initialCharges != null)
            {
                using (var sw = new StringWriter())
                {
                    using (var xw = XmlWriter.Create(sw, settings))
                    {
                        xw.WriteStartElement("rows");
                        foreach (var item in initialCharges)
                        {
                            xw.WriteStartElement("row");
                                xw.WriteStartElement("SID");
                                xw.WriteString(item.SID.ToString());
                                xw.WriteEndElement();
                                xw.WriteStartElement("SIDPers");
                                xw.WriteString(item.SIDPers.ToString());
                                xw.WriteEndElement();
                                xw.WriteStartElement("CreatedBy");
                                xw.WriteString("Carga Inicial");
                                xw.WriteEndElement();
                                xw.WriteStartElement("CustomSticker_UserWeb");
                                xw.WriteString(users);
                                xw.WriteEndElement();
                                xw.WriteStartElement("CustomSticker_CatCustomStickersStatus");
                                xw.WriteString("1");
                                xw.WriteEndElement();
                            xw.WriteEndElement();
                        }
                        xw.WriteEndElement();
                        xw.Flush();
                    }
                    xmlEstado = sw.ToString();
                }
            }         
                    
           // listaPsiUv = this.SirficDbContext.Database.SqlQuery<DirectorioPsiUvDto>("execute NMX.SP_DirectoriosPSIyUVA @tipo, @xmlEstados, @xmlCompetencias", sqlParams).ToList();
            
            return xmlEstado;
        }

        public Result InitialChargeCustomSticker(Assignment assignment)
        {
            Result result = new Result();
            try
            {          
                 result = ValidateAssignment(assignment);
                if (result.result == 1)
                {
                    var listSidInitial = readFileInitial(assignment.urlFile);
                    if (listSidInitial != null)
                    {
                        string xmlStickers = GenerationXMLStickers(listSidInitial, assignment.IdUserWebSet.ToString());

                        var parameters = new[] {
                            new SqlParameter("@myXML", (string.IsNullOrEmpty(xmlStickers) ? Convert.DBNull : xmlStickers) )
                        };

                        var z = _storeProcedureDB.EjecutarStoredProcedure<InitialChargeResult>("dbo.uspCustomStickersSetInsertMassive", parameters, reader =>
                        {
                            return new InitialChargeResult
                            {
                                //En esta sección van todas las propiedades de la Entidad UserEntity y ["Aqui"] van mapeados a los nombres de las columnas que recuperaste en la consulta de base de datos
                                Total = (int)reader["Total"],
                                Result = (int)reader["Result"]
                            };
                        }).FirstOrDefault();
                        
                        if (z.Result == 1)
                        {
                            result.result = 1; result.message = "Se agregaron "+ z.Total+ " Stickers";
                        }
                        else if (z.Result == 2 && z.Total==0)
                        {
                            result.result = 2; result.message = "Ocurrio  un problema de BD, intentar mas tarde";
                        }
                        else
                        {
                            result.result = 2; result.message = "No se insertaron regsitros ya que exiten " +z.Total+" Sticker ya registrados en la bd";
                        }

                    }
                    else
                   {
                       result.result = 3; result.message = "Sin datos en el archivo";
                    }

                }                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        #endregion


        public Result vehicleAssignmentCustomSticker(UidDtos uidDtos)
        {
            Result result = new Result();
            EncryptionAES256 encryptionAES256 = new EncryptionAES256(_keyAES256, _keyAES256GOSMO);

            try
            {              
                if (uidDtos.IdUserWebSet == 0)
                    {
                        result.result = 3; result.message = "El usuario no es valido.";
                        return result;
                }else {
                        if (String.IsNullOrEmpty(uidDtos.UID))
                        {
                            result.result = 3; result.message = "El sticker no es valido.";
                            return result;
                        }
                }

                result = ValidateUser(uidDtos.IdUserWebSet);

               if (result.result == 1)   {
                   // result = vehicleAssignment(vehicleAssignmentDtos, validate.message);
                    var  customStickers = _customStickers.GetCustomStickersxUID(encryptionAES256.Encryption(uidDtos.UID, 2));
                    if (customStickers == null)
                    {
                        //No existe registro de UID
                        result.result = 2;
                        result.message = "El Sticker no está dado de alta.";
                    }
                    else
                    {
                        if (customStickers.CustomStickerTag == null)
                        {
                            result.result = 1;
                            result.message = "Sticker disponible para asignación de vehículo.";
                        }
                        else
                        {
                            result.result = 2;
                            result.message = "Sticker no disponible.";
                        }
                    }

               }
                    
            }
            catch (Exception ex)
            {
                result.result = 2;
                result.message = ex.Message;
            }
            return result;
        }

    }
}
