using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //tüm işlem sonuçları için
        public SuccessDataResult(T data, string messages) : base(data,true,messages)
        {
            //data ver true döndür ve mesaj ver 
        }
        //mesaj vermek istemiyorsa
        public SuccessDataResult(T data):base(data,true)
        {
            
        }
        //Data default verilir sadece mesaj verir
        public SuccessDataResult(string messages):base(default,true,messages)
        {
            
        }
        public SuccessDataResult():base(default,true)
        {
            //hiçbir şey vermez
            
        }
    }
}
