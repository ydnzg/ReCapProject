using Business.Abstrack;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintanenceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorListed);
        }

        public IDataResult<Color> GetByColorId(int colorId)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<Color>(Messages.MaintanenceTime);
            }
            
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId), Messages.ColorListedByColorId);
        }
    }
}
