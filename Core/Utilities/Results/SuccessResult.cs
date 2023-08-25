using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //Result tan implement edildiği için base(true) verilir Base true ise çalışır
        public SuccessResult() :base(true)
        { }
        public SuccessResult(string message):base(true,message)
        {
            //mesajlar constants taki messages classından gelir
        }
    }
}
