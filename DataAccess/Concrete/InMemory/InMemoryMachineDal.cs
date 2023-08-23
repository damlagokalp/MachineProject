using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryMachineDal : IMachineDal
    {
        List<Machine> _machines; //bellekte araba listesi oluşturuldu
        public InMemoryMachineDal()
        {
            _machines = new List<Machine>() 
            { 
            //ürünler kaydedildi
            new Machine { MachineId = 1, BrandId = 10, Description = "A6 Housing", ProducerName = "A üreticisi" },
            new Machine { MachineId = 2, BrandId = 20, Description = "A6 Cylinder", ProducerName = "B üreticisi" },
            new Machine { MachineId = 3, BrandId = 30, Description = "A6 Drive Shaft", ProducerName = "C üreticisi" },
            new Machine { MachineId = 4, BrandId = 40, Description = "A6 Control Lens", ProducerName = "D üreticisi" },
            new Machine { MachineId = 5, BrandId = 50, Description = "A6 IBV", ProducerName = "E üreticisi" },

            };
        }
        //IMachineDal daki fonksiyonların implementasyonu
        public void Add(Machine machine)
        {
            _machines.Add(machine);//makine eklenir
        }

        public void Delete(Machine machine)
        {
            Machine machineToDelete= null;
            machineToDelete=_machines.SingleOrDefault(p=>p.MachineId ==machine.MachineId); //LINQ kullanımı  // SingleOrDefault Id gibi işlemlerde kullanılır tek mi değil mi
        }

        public Machine Get(Expression<Func<Machine, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Machine> GetAll()
        {
            return _machines.ToList();
        }

        public List<Machine> GetAll(Expression<Func<Machine, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Machine> GetById(int id)
        {
            return _machines.Where(p=>p.MachineId == id).ToList();//Where şart
        }

        public void Update(Machine machine)
        {
            Machine updateMachine= _machines.SingleOrDefault(p=>p.MachineId == machine.MachineId);

            updateMachine.MachineId = machine.MachineId;
            updateMachine.BrandId= machine.BrandId;
            updateMachine.Description=machine.Description;
            updateMachine.ProducerName = machine.ProducerName;
        }
    }
}
