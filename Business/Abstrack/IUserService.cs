using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUsersByUserId(int userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);


    }
}
