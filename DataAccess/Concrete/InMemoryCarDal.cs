using DataAccess.Abstrack.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            
            new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2019,DailyPrice=236,Description="Benzinli ve otomatik"},
            new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2005,DailyPrice=100,Description="Benzinli ve manuel"},
            new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2019,DailyPrice=480,Description="Dizel ve otomatik"},
            new Car{Id=4,BrandId=3,ColorId=3,ModelYear=2017,DailyPrice=420,Description="Benzinli ve otomatik"},
            new Car{Id=5,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=500,Description="Dizel ve manuel"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

       
        public Car GetById(int carId)
        {
            Car carById = _cars.SingleOrDefault(c => c.Id == carId);
            return carById;

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
