﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context=new RentCarContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = b.BrandId,
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,
                                 ColorId=co.ColorId,
                                 ColorName=co.ColorName,
                                 BrandName=b.BrandName
                                 
                             };

                return result.ToList();
            }
        }
    }
}
