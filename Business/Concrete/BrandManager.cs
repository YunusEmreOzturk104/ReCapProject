using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandsService
    {
        IBrandsDal _brandDal;
        public BrandManager(IBrandsDal brandsDal)
        {
            _brandDal = brandsDal;
        }
      

        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

     

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll(); 
        }
    }
}
