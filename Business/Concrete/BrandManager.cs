using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;



namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetByBrandId(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }
    }
}
