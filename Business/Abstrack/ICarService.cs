using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);

        Car GetByCarId(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<CarDetailDto> GetCarDetails();
    }
}
