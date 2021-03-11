using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetByBrandId(int brandId);
    }
}
