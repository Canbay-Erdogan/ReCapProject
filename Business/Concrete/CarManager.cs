using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==14)
            {
               return new ErrorDataResult<List<Car>>(Messages.Maintance);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll().Where(c=>c.BrandId==brandId).ToList(),Messages.ListedByBrandId);
        }

        public IDataResult<Car> GetCarsByColorId(int ColorId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.ColorId == ColorId));
        }

        public IDataResult<Car> GetCarsById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetail()
        {
            return new SuccessDataResult <List<CarDetailDto >> (_carDal.GetCarDetailDtos(),Messages.ListedCarDetail);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
