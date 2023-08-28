using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]//-->istekte bulunma şekli
    [ApiController]//--> Attribute
    public class MachinesController : ControllerBase
    {
        //loosely coupled
        //IoC Container -- Inversion of Control 

        IMachineService _machineService;
        public MachinesController(IMachineService machineService)
        {
            _machineService = machineService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            //swagger
            //dependency chain

            //IMachineService machineService = new MachineManager(new EfMachineDal());

            var result = _machineService.GetAll();//IDataResult tan GetAll gelir

            if (result.Success)
            {//işlem başarılı ise datayı döndürür
                return Ok(result.Data);
            }
            //başarısız ise
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _machineService.GetAllById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Machine machine)
        {
            var result = _machineService.AddMachine(machine); //Clienttan gönderilen ürün buraya konur
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}