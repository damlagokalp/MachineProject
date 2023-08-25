using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IResult AddMachine(Machine machine);
        IResult DeleteMachine(Machine machine);
        IResult UpdateMachine(Machine machine);
        IDataResult<List<Machine>> GetAll();
        IDataResult<List<Machine>> GetAllById(int id);//id ye göre listelenir
        IDataResult<List<Machine>> GetMachineByBrandId(int brandId);
        IDataResult<List<MachineDetailDto>> GetMachineDetails();

    }
}
