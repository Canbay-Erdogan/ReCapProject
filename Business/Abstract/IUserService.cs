using Core.Entity.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService 
    {
        void Add(User user);
        List<OperationClaim> GetClaims(Core.Entity.Concrete.User user);
        Core.Entity.Concrete.User GetByMail(string email);

    }
}
