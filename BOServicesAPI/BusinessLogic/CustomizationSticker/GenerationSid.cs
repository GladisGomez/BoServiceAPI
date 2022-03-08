using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.BusinessLogic.CustomizationStiker
{
    public class GenerationSid
    {
        public  string NewSid() {
            return Sid();
        }

        private string Sid() {

            String dateSid = String.Empty;
            DateTime dateTimeSid = DateTime.Now;
            Random _random = new Random();

            //DateTime
            dateSid = dateTimeSid.ToString("yyMMddHHmmssff", CultureInfo.InvariantCulture);
            //Random 
            dateSid += _random.Next(1000).ToString("D4");

            return dateSid;
        }

        private bool ValidateSid(string sid) {
            return true;
        }

        private bool AddSid(string sid)
        {
            return true;
        }

        private bool AddRSid()
        {
            return true;
        }

    }
}
