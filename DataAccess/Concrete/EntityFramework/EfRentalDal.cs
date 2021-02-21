﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal: IfEntityRepositoryBase<Rental,RentCarContext>,IRentalDal
    {
    }
}