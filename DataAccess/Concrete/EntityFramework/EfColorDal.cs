using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfColorDal : IfEntityRepositoryBase<Color, RentCarContext>, IColorDal

    {
       
    }
}
