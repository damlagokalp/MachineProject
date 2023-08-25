using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager()
        {
            _brandDal = _brandDal;   
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("Marka eklendi");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Marka silindi");
        }

        public IDataResult<List<Brand>> GetAll()
        {var result= new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),"Markalar listelendi");
            return result;
        }

        public  IDataResult<List<Brand>> GetAllById(int id)
        {
            var result = new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.BrandId ==id));
            return result;
        }

        public IResult Update(Brand brand)
        {
           _brandDal.Update(brand);
            return new SuccessResult("Marka güncellendi");
        }

       

        
    }
}
