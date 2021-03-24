using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetCarsByBrandId(int brandId);
        IDataResult<Car> GetCarsByColorId(int ColorId);
    }
}
