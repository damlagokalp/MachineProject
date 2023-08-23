using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MachineManager : IMachineService
    {
        IMachineDal _machineDal;// IMachineDal dan referans alınır
        public MachineManager(IMachineDal machineDal)
        {
            _machineDal = machineDal;
        }
        public List<Machine> GetAll()
        {
            return _machineDal.GetAll();
        }

        public List<Machine> GetAllById(int id)
        {
            return _machineDal.GetAll(p => p.MachineId == id);
        }

        public List<Machine> GetMachineByBrandId(int brandId)
        {
            return _machineDal.GetAll(p=>p.BrandId == brandId);
        }

        
        
    }
}