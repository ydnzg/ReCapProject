using Business.Abstrack;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r=>r.ReturnDate != null);
            if (result == null)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
            
          
        }

        public IResult Delete(Rental rental)
        {
            var result = _rentalDal.Get(r => r.ReturnDate == null);

            if (result != null)
            {
                return new ErrorResult(Messages.RentalDeletedError);
            }
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintanenceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<Rental> GetRentalByRentalId(int rentalId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Rental>();
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }

        public IResult Update(Rental rental)
        {
            var result = _rentalDal.Get(r => r.ReturnDate == null);
            if (result != null)
            {
                return new ErrorResult(Messages.PasswordInvalid);
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
