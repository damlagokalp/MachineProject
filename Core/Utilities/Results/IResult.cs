using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //get -> sadece okunabilir, bir şeyi return et demek 
        bool Success { get; }
        string Message { get; }
    }
}
