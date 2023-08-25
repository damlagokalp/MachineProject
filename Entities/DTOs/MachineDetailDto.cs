using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MachineDetailDto:IDto
    {
        //join
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string ProducerName { get; set; }//üretici adı
        public int BrandId { get; set; }
        public int Description { get; set; }

    }
}
