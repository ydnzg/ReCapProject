
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //GETALL
            foreach (var c0 in carManager.GetAll())
            {
                Console.WriteLine(c0.Id + " " + c0.BrandId + " " + c0.ColorId + " " + c0.ModelYear + " " + c0.DailyPrice + " " + c0.Description);

            }

            //GETBYBRANDID
            foreach (var c in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(c.Id + " " + c.BrandId + " " + c.ColorId + " " + c.ModelYear + " " + c.DailyPrice + " " + c.Description);
            }

            //GETBYCOLORID
            foreach (var c1 in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(c1.Id + " " + c1.BrandId + " " + c1.ColorId + " " + c1.ModelYear + " " + c1.DailyPrice + " " + c1.Description);
            }

            //GETBYCARID
            var car = carManager.GetByCarId(11);
            Console.WriteLine(car.ModelYear);

            Car car1 = new Car
            {
                Id = 13,
                BrandId = 6,
                ColorId = 2,
                ModelYear=1989,
                DailyPrice=250,
                Description= "Benzinli ve manual",
                CarName = "Mustang"
            };

            Car car2 = new Car
            {
                Id = 13,
                BrandId = 6,
                ColorId = 3,
                ModelYear = 1993,
                DailyPrice = 370,
                Description = "Benzinli ve manual",
                CarName = "Fiesta"
            };

            //ADD
            carManager.Add(car1);
            var carAdded = carManager.GetByCarId(13);
            Console.WriteLine(carAdded.Id + " " + carAdded.ModelYear + " " + carAdded.ColorId);


            //UPDATE
            carManager.Update(car2);
            var carUpdated = carManager.GetByCarId(12);
            Console.WriteLine(carUpdated.Id + " " + carUpdated.ModelYear + " " + carUpdated.ColorId);

            //DELETE
            carManager.Delete(car2);

            //GETALL
            foreach (var car3 in carManager.GetAll())
            {
                Console.WriteLine(car3.Id + " " + car3.BrandId + " " + car3.ColorId + " " + car3.ModelYear + " " + car3.DailyPrice + " " + car3.Description);
            }

            //GETCARDETAILS-DTO
            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine
                    (
                    "car name : " + carDetail.CarName + " * " +
                    "brand name : " + carDetail.BrandName + " * " +
                    "color name : " + carDetail.ColorName + " * " +
                    "daily price : " + carDetail.DailyPrice
                    );
            }



        }



    }
}
