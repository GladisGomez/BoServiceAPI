using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.EncryptBO
{
    public class TagEncrypt
    {
        private bool _Ok;
        private string _eSid;


        public bool TagOk { get => _Ok; set => _Ok = value; }
        public string ESID { get => _eSid; set => _eSid = value; }
    }
}
