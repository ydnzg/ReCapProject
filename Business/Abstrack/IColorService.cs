using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetByColorId(int colorId);
    }
}
