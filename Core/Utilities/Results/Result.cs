using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        //------------METHOD OVERLOADİNG
        public Result(bool success)//Result a bool gönderilir
        {
            Success = success;//Set edilir
        }

        //This bu class demek
        public Result(bool success ,string message):this(success) // bool ve string gönderilir
        {
            Message = message;//set edilir
        }


        //implemenet edildi 
        //getter readonly dir (constructor da set edilebilir)
        public bool Success { get; }

        public string Message { get; }
    }
}
