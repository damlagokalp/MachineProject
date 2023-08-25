using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Supply:IEntity
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SupplyDate { get; set; }
        public DateTime ReturnDate { get; set;}
    }
}
