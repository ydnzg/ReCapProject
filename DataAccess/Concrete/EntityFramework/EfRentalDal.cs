
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstrack;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (var context = new RentCarContext())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars on rent.CarId equals car.Id
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join cus in context.Customers on rent.CustomerId equals cus.CustomerId
                             join user in context.Users on cus.UserId equals user.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = rent.RentalId,
                                 CarId=car.Id,
                                 CustomerId=cus.CustomerId,
                                 BrandName = brand.BrandName,
                                 Customer=user.FirstName + " " + user.LastName, 
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate,
                             };

                return result.ToList();
            }
        }
    }
}
