﻿using Business.Abstrack;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            //BUSINESS CODE
          
            

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionTest(Car car)
        {
            Add(car);

            if (car.DailyPrice < 1000)
            {
                throw new Exception("düşük ücet");
            }
            Add(car);

            return null;
        }

        public IResult Delete(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintanenceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);

        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Car> GetByCarId(int carId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Car>();
            }
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId),Messages.CarListedById);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintanenceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarDetailsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>();
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>();
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.ColorId==id));
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
