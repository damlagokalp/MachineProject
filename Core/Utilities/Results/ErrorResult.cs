using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        //base false ise çalışır
        public ErrorResult(string  message) : base(false,message)
        {
            //mesajlar constantstta
        }
        public ErrorResult():base(false)
        {
            
        }
    }
}
