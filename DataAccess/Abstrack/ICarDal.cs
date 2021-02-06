using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack.InMemory
{
    public interface ICarDal
    {
        Car GetById(int carId);
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetAllByBrand(int brandId);

    }
}
