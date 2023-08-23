using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMachineService
    {
        List<Machine> GetAll();
        List<Machine> GetAllById(int id);//id ye göre listelenir
        List<Machine> GetMachineByBrandId(int brandId);
        
    }
}
