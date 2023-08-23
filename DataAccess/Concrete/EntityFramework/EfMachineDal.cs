using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMachineDal: EfEntityRepositoryBase<Machine, MachineContext>, IMachineDal
    {
        //Veritabanı operasyonları yazılır
        // EfEntityRepositoryBase in içinde IBrandDal'ın çindeki operasyonlar olduğu için onları kullanır

        public List<MachineDetailDto> GetMachineDetails()
        {
            using (MachineContext context=new MachineContext())
            {
                //machines ve brands tabloları linq ile join edildi
                var result = from m in context.Machines
                             join b in context.Brands
                             on m.BrandId equals b.BrandId

                             select new MachineDetailDto
                             {//ne nerden alınır gösterir
                                 MachineId = m.MachineId,
                                 ProducerName = m.ProducerName,
                                 BrandId = m.BrandId,
                             };

                return result.ToList();
            }
            
        }
    
    }
}
