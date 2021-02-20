using Business.Abstrack;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;



namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(EfBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintanenceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.BrandListed);
        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<Brand>(Messages.MaintanenceTime);
            }

            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId),Messages.BrandListedByBrandId);
        }
    }
}
