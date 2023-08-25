using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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

        public IResult Add(Producer producer)
        {
            _producerDal.Add(producer);
            return new SuccessResult("Üretici eklendi");
        }

        public IResult Delete(Producer producer)
        {
           _producerDal.Delete(producer);
            return new SuccessResult("Üretici silindi");
        }

        public IDataResult<List<Producer> >GetAll()
        {
            var result = new SuccessDataResult<List<Producer>>(_producerDal.GetAll());
            return result;
        }

        public IDataResult<List<Producer> >GetAllById(int id)
        {
            var result = new SuccessDataResult<List<Producer>>(_producerDal.GetAll(p => p.ProducerId == id));
            return result;
            
        }

        public IResult Update(Producer producer)
        {
           _producerDal.Update(producer);
            return new SuccessResult("Üretici güncellendi");
        }

        

       
    }
}
