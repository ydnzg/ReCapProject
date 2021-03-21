
using Business.Concrete;
using Core.Entities.Concrete;
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

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

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

            //var result1 = brandManager.GetByBrandId(5);

            //if (result1.Success == true)
            //{

            //        Console.WriteLine
            //            (
            //            "brand name : " + result1.Data.BrandName + " * " +
            //            "brand id : " + result1.Data.BrandId

            //            );

            //    Console.WriteLine(result1.Message);

            //}
            //else
            //{
            //    Console.WriteLine(result1.Message);
            //}

            //UserManager userManager = new UserManager(new EfUserDal());

            //var result = userManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var user in result.Data)
            //    {


            //          Console.WriteLine("user id = " + user.UserId + " / " +
            //                  "firstname = " + user.FirstName + " / " +
            //                  "lastname = " + user.LastName + " / " +
            //                  "email = " + user.Email + " / " +
            //                  "passworrd = " + user.Password);


            //    }
            //    Console.WriteLine(result.Message);

            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            User user1 = new User
            {
                UserId = 1,
                FirstName = "İsmet",
                LastName = "Kara",
                Email = "i.kara@gmail.com",
                Password="Ismet.12"
            };

            User user2 = new User
            {
                UserId = 2,
                FirstName = "Ece",
                LastName = "Çakır",
                Email = "cakirece@gmail.com",
                Password = "Ece_c4"
            };
            User user3 = new User
            {
                UserId = 3,
                FirstName = "Rasim",
                LastName = "Helva",
                Email = "rassim@gmail.com",
                Password = "Helva.123"
            };
            User user4 = new User
            {
                UserId = 4,
                FirstName = "Seçkin",
                LastName = "Tutuk",
                Email = "tttutuk@gmail.com",
                Password = "123456"
            };
            User user5 = new User
            {
                UserId = 5,
                FirstName = "Banu",
                LastName = "Mavi",
                Email = "mavibanu@gmail.com",
                Password = "Mavi.543"
            };
            User user6 = new User
            {
                UserId = 5,
                FirstName = "Banu",
                LastName = "Mavi",
                Email = "b.mavi@gmail.com",
                Password = "Banu.12345"
            };

            //**İLK 5 KULLANICIYI EKLE, 6. KULLANICIYI GÜNCELLEME İÇİN KULLAN , 1. KULLANICIYI SİL
            //userManager.Add(user1);
            //Console.WriteLine("user id = " + user1.UserId + " / " +
            //                  "firstname = " + user1.FirstName + " / " +
            //                  "lastname = " + user1.LastName + " / " +
            //                  "email = " + user1.Email + " / " +
            //                  "passworrd = " + user1.Password          );
            //userManager.Add(user2);
            //Console.WriteLine("user id = " + user2.UserId + " / " +
            //                  "firstname = " + user2.FirstName + " / " +
            //                  "lastname = " + user2.LastName + " / " +
            //                  "email = " + user2.Email + " / " +
            //                  "passworrd = " + user2.Password);
            //userManager.Add(user3);
            //Console.WriteLine("user id = " + user3.UserId + " / " +
            //                  "firstname = " + user3.FirstName + " / " +
            //                  "lastname = " + user3.LastName + " / " +
            //                  "email = " + user3.Email + " / " +
            //                  "passworrd = " + user3.Password);
            //userManager.Add(user4);
            //Console.WriteLine("user id = " + user4.UserId + " / " +
            //                  "firstname = " + user4.FirstName + " / " +
            //                  "lastname = " + user4.LastName + " / " +
            //                  "email = " + user4.Email + " / " +
            //                  "passworrd = " + user4.Password);
            //userManager.Add(user5);
            //Console.WriteLine("user id = " + user5.UserId + " / " +
            //                  "firstname = " + user5.FirstName + " / " +
            //                  "lastname = " + user5.LastName + " / " +
            //                  "email = " + user5.Email + " / " +
            //                  "passworrd = " + user5.Password);

            //userManager.Update(user6);
            //userManager.Delete(user1);

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //var result = customerManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var customer in result.Data)
            //    {


            //        Console.WriteLine("customer id = " + customer.CustomerId + " / " +
            //                          "user id = " + customer.UserId + " / " +
            //                          "company name = " + customer.CompanyName);


            //    }
            //    Console.WriteLine(result.Message);

            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            Customer customer1 = new Customer
            {
                CustomerId=1,
                UserId = 3,
                CompanyName = "Rasim Makina"
               
            };
            Customer customer2 = new Customer
            {
                CustomerId = 2,
                UserId = 5,
                CompanyName = "Mavi Reklamcılık"

            };
            Customer customer3 = new Customer
            {
                CustomerId = 3,
                UserId = 2,
                CompanyName = "Çakır Holding"

            };
            Customer customer4 = new Customer
            {
                CustomerId = 4,
                UserId = 4,
                CompanyName = "Yılmaz Pastanesi"

            };
            Customer customer5 = new Customer
            {
                CustomerId = 3,
                UserId = 2,
                CompanyName = "Yılmaz Pastanesi"

            };

            //ilk 4 customer eklenecek, 5. müşteri bilgileri update için kullanılacak ve customer4 silinecek

            //customerManager.Add(customer1);
            //Console.WriteLine("customer id = " + customer1.CustomerId + " / " +
            //                  "user id = " + customer1.UserId + " / " +
            //                  "company name = " + customer1.CompanyName );

            //customerManager.Add(customer2);
            //Console.WriteLine("customer id = " + customer2.CustomerId + " / " +
            //                  "user id = " + customer2.UserId + " / " +
            //                  "company name = " + customer2.CompanyName);

            //customerManager.Add(customer3);
            //Console.WriteLine("customer id = " + customer3.CustomerId + " / " +
            //                  "user id = " + customer3.UserId + " / " +
            //                  "company name = " + customer3.CompanyName);

            //customerManager.Add(customer4);
            //Console.WriteLine("customer id = " + customer4.CustomerId + " / " +
            //                  "user id = " + customer4.UserId + " / " +
            //                  "company name = " + customer4.CompanyName);

            //customerManager.Update(customer5);
            //customerManager.Delete(customer4);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //var result = rentalManager.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var rental in result.Data)
            //    {

            //        Console.WriteLine("rental id = " + rental.RentalId + " / " +
            //                          "car id = " + rental.CarId + " / " +
            //                          "customer id = " + rental.CustomerId + " / " +
            //                          "rent date = " + rental.RentDate + " / " +
            //                          "return date = " + rental.ReturnDate);


            //    }
            //    Console.WriteLine(result.Message);

            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            Rental rental1 = new Rental
            {
                RentalId = 1,
                CarId = 1,
                CustomerId = 2,
                RentDate=new DateTime(2020,02,08),
                ReturnDate= new DateTime(2020, 02, 10)

            };

            Rental rental2 = new Rental
            {
                RentalId = 2,
                CarId = 7,
                CustomerId = 3,
                RentDate = new DateTime(2019, 04, 15),
                ReturnDate = new DateTime(2019, 05, 25)

            };

            Rental rental3 = new Rental
            {
                RentalId = 3,
                CarId = 9,
                CustomerId = 1,
                RentDate = new DateTime(2021, 01, 01),
                ReturnDate = new DateTime(2021, 01, 30)

            };

            Rental rental4 = new Rental
            {
                RentalId = 3,
                CarId = 3,
                CustomerId = 1,
                RentDate = new DateTime(2021, 01, 01),
                ReturnDate = new DateTime(2021, 01, 30)

            };

            Rental rental5 = new Rental
            {
                RentalId = 5,
                CarId = 4,
                CustomerId = 1,
                RentDate = new DateTime(2021, 01, 01),
                ReturnDate = null

            };

            //ilk üç rental ı ekle, rental4 ile rental3 ün carid bilgisini güncelle,rental2 yi sil
            //rentalManager.Add(rental1);
            //Console.WriteLine("rental id = " + rental1.RentalId + " / " +
            //                  "car id = " + rental1.CarId + " / " +
            //                  "customer id = " + rental1.CustomerId + " / " +
            //                  "rent date = " + rental1.RentDate + " / " +
            //                  "return date = " + rental1.ReturnDate );

            //rentalManager.Add(rental2);
            //Console.WriteLine("rental id = " + rental2.RentalId + " / " +
            //                  "car id = " + rental2.CarId + " / " +
            //                  "customer id = " + rental2.CustomerId + " / " +
            //                  "rent date = " + rental2.RentDate + " / " +
            //                  "return date = " + rental2.ReturnDate);

            //rentalManager.Add(rental3);
            //Console.WriteLine("rental id = " + rental3.RentalId + " / " +
            //                  "car id = " + rental3.CarId + " / " +
            //                  "customer id = " + rental3.CustomerId + " / " +
            //                  "rent date = " + rental3.RentDate + " / " +
            //                  "return date = " + rental3.ReturnDate);

            //rentalManager.Update(rental4);

            //rentalManager.Delete(rental2);

            //return date null ilse araba kiralanamaz
            //rentalManager.Add(rental5);
           

        }



    }
}
