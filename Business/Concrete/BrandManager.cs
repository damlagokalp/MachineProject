﻿using Business.Abstract;
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
        public List<Brand> GetAll()
        {
           return  _brandDal.GetAll();
        }

        public List<Brand> GetAllById(int id)
        {
            return _brandDal.GetAll(p=>p.BrandId == id);
        }
    }
}