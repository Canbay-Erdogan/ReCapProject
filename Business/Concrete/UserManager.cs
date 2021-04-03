using Business.Abstract;
using Core.Entity.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(Core.Entity.Concrete.User entity)
        {
            _userDal.Add(entity);
        }

        public IResult Delete(Core.Entity.Concrete.User entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Core.Entity.Concrete.User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Core.Entity.Concrete.User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(Core.Entity.Concrete.User user)
        {
            return _userDal.GetClaims(user);
        }

        public IResult Update(Core.Entity.Concrete.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
