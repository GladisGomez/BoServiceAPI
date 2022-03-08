using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities.CustomizationSticker
{
    public class Result
    {
        public Result() { }
        private short _result = 0;
        private string _message = String.Empty;

        //1.-Hecho
        //2.-No encontrado
        //3.-Datos de entrada incorrectos

        public short result { get => _result; set => _result = value; }
        public string message { get => _message; set => _message = value; }
    }


    public class ResultData<T> {
        private Result _result = new Result();

        public Result result { get => _result; set => _result = value; }
        public T Data { get; set; }
    }
}
