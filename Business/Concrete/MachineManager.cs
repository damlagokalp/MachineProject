                                                                                                                                                                                                                                                                                                                                                                                                                                            using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        public IResult AddMachine(Machine machine)
        {
            if (machine.Description.Length < 2)
            {
                return new ErrorResult(Messages.MachineNameInvalid);// 2 karakterden küçükse başarısız ve errorResult kullanılır

            }
            _machineDal.Add(machine);
            return new SuccessResult(Messages.MachineAdded);//eğer başarılı ise ürün eklenir 
        }

        public IResult DeleteMachine(Machine machine)
        {
            return new SuccessResult(Messages.MachineDeleted);
        }

        public IDataResult<List<Machine>> GetAll()
        {
            if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<Machine>>(Messages.MaintenanceTime);//Maintenance: bakım zamanı
            }

            return new SuccessDataResult<List<Machine>>(_machineDal.GetAll(), Messages.MachinesListed);//ürünleri verir - burada bir data da döndürmek ister,işlem sonucunu verir(Messages.ProductListed) mesaj verir
        }

        public IDataResult<List<Machine>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Machine>>(_machineDal.GetAll(p => p.MachineId == id)); 
        }

        public IDataResult<List<Machine>> GetMachineByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Machine>>(_machineDal.GetAll(p => p.BrandId == brandId));
        }
        public IDataResult<List<MachineDetailDto>> GetMachineDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<MachineDetailDto>>(Messages.MaintenanceTime);//Maintenance: bakım zamanı
            }

            return new SuccessDataResult<List<MachineDetailDto>>(_machineDal.GetMachineDetails());
        }

        public IResult UpdateMachine(Machine machine)
        {
            _machineDal.Update(machine);
            return new SuccessResult(Messages.MachineUpdated);
        }
    }




}