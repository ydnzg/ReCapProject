
using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id+" "+car.BrandId+" " +car.ColorId+" "+car.ModelYear+" "+car.DailyPrice+" "+car.Description);
               
            }
        }
    }
}
