using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetRentalByRentalId(int rentalId);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
