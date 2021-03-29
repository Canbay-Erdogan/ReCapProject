using Core.DataAccess;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        //IDataResult<Car> Get();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetCarsById(int carId);
        IDataResult <List<Car>> GetCarsByBrandId(int brandId);
        IDataResult <List<CarDetailDto>> GetCarsDetail();
        IDataResult<Car> GetCarsByColorId(int ColorId);
    }
}
