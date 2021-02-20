
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
            //CarManager carManager = new CarManager(new EfCarDal());

            //GETALL
            //foreach (var c0 in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(c0.Id + " " + c0.BrandId + " " + c0.ColorId + " " + c0.ModelYear + " " + c0.DailyPrice + " " + c0.Description);

            //}

            ////GETBYBRANDID
            //foreach (var c in carManager.GetCarsByBrandId(2).Data)
            //{
            //    Console.WriteLine(c.Id + " " + c.BrandId + " " + c.ColorId + " " + c.ModelYear + " " + c.DailyPrice + " " + c.Description);
            //}

            ////GETBYCOLORID
            //foreach (var c1 in carManager.GetCarsByColorId(3).Data)
            //{
            //    Console.WriteLine(c1.Id + " " + c1.BrandId + " " + c1.ColorId + " " + c1.ModelYear + " " + c1.DailyPrice + " " + c1.Description);
            //}

            ////GETBYCARID
            //var car = carManager.GetByCarId(11).Data;
            //Console.WriteLine(car.ModelYear);

            //Car car1 = new Car
            //{
            //    Id = 13,
            //    BrandId = 6,
            //    ColorId = 2,
            //    ModelYear=1989,
            //    DailyPrice=250,
            //    Description= "Benzinli ve manual",
            //    CarName = "Mustang"
            //};

            //Car car2 = new Car
            //{
            //    Id = 13,
            //    BrandId = 6,
            //    ColorId = 3,
            //    ModelYear = 1993,
            //    DailyPrice = 370,
            //    Description = "Benzinli ve manual",
            //    CarName = "Fiesta"
            //};

            ////ADD
            //carManager.Add(car1);
            //var carAdded = carManager.GetByCarId(13).Data;
            //Console.WriteLine(carAdded.Id + " " + carAdded.ModelYear + " " + carAdded.ColorId);


            ////UPDATE
            //carManager.Update(car2);
            //var carUpdated = carManager.GetByCarId(12).Data;
            //Console.WriteLine(carUpdated.Id + " " + carUpdated.ModelYear + " " + carUpdated.ColorId);

            ////DELETE
            //carManager.Delete(car2);

            ////GETALL
            //foreach (var car3 in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(car3.Id + " " + car3.BrandId + " " + car3.ColorId + " " + car3.ModelYear + " " + car3.DailyPrice + " " + car3.Description);
            //}

            //GETCARDETAILS-DTO

            //var result = carManager.GetCarDetails();

            //if (result.Success==true)
            //{
            //    foreach (var carDetail in result.Data)
            //    {
            //        Console.WriteLine
            //            (
            //            "car name : " + carDetail.CarName + " * " +
            //            "brand name : " + carDetail.BrandName + " * " +
            //            "color name : " + carDetail.ColorName + " * " +
            //            "daily price : " + carDetail.DailyPrice
            //            );
            //    }
            //    Console.WriteLine(result.Message);
           
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

          
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //var result = colorManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var colorDetail in result.Data)
            //    {
            //        Console.WriteLine
            //            (
            //            "color name : " + colorDetail.ColorName + " * " +
            //            "color id : " + colorDetail.ColorId + " * " 
                    
            //            );
            //    }
            //    Console.WriteLine(result.Message);

            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //var result = brandManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var brandDetail in result.Data)
            //    {
            //        Console.WriteLine
            //            (
            //            "brand name : " + brandDetail.BrandName + " * " +
            //            "brand id : " + brandDetail.BrandId + " * "

            //            );
            //    }
            //    Console.WriteLine(result.Message);

            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            var result1 = brandManager.GetByBrandId(5);

            if (result1.Success == true)
            {
                
                    Console.WriteLine
                        (
                        "brand name : " + result1.Data.BrandName + " * " +
                        "brand id : " + result1.Data.BrandId

                        );
              
                Console.WriteLine(result1.Message);

            }
            else
            {
                Console.WriteLine(result1.Message);
            }
        }



    }
}
