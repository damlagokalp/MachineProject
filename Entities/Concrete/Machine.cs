using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Machine:IEntity
    {
        public int MachineId { get; set; }
        public int BrandId { get; set; }
        public string ProducerName { get; set; }//üretici adı
        public string Description { get; set; }
    }
}
