using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        public IDataResult<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetCarsByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }
    }
}
