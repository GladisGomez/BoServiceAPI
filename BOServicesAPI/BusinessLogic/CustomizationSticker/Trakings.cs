using BOServicesAPI.DataBase;
using BOServicesAPI.DBContext;
using BOServicesAPI.Entities.CustomizationSticker;
using BOServicesAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.BusinessLogic.CustomizationSticker
{
    public class Trakings
    {
        private readonly IConfiguration _configuration;
        private readonly OxxoBoContext _context;
        private CustomStickersTrakingDB _customStickersTrakingDB;

        public Trakings(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _customStickersTrakingDB = new CustomStickersTrakingDB(_context);
            _configuration = configuration;
        }


        public List<CustomStickersTrakings> getTrakingDB(CustomSid customSid)
        {
            List<CustomStickersTrakings> listTrakings = new List<CustomStickersTrakings>();
            if (String.IsNullOrEmpty(customSid.SidPersonalizado))
            {
                 
            }
            else
            {
                 listTrakings = _customStickersTrakingDB.listCustomStickers();
            }

            return listTrakings;




        }
    }
}
