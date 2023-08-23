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
    
    public class ProducerManager : IProducerService
    {
        IProducerDal _producerDal;
        public ProducerManager(IProducerDal producerDal)
        {
            _producerDal = producerDal;
            
        }

        public List<Producer> GetAll()
        {
            return _producerDal.GetAll();
        }

        public List<Producer> GetAllById(int id)
        {
           return  _producerDal.GetAll(p=>p.ProducerId == id);
        }
    }
}
