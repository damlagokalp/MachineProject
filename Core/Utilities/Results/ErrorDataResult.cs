using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //tüm işlem sonuçları için
        public ErrorDataResult(T data, string messages) : base(data, false, messages)
        {
            //data ver false döndür ve mesaj ver 
        }
        //mesaj vermek istemiyorsa
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //Data default verilir sadece mesaj verir
        public ErrorDataResult(string messages) : base(default, false, messages)
        {

        }
        public ErrorDataResult() : base(default, false)
        {
            //hiçbir şey vermez

        }
    }
}
