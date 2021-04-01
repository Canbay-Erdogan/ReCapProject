using Business.Abstract;
using Business.Constants;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carimagedal;
        public CarImageManager(ICarImageDal carimagedal)
        {
            _carimagedal = carimagedal;
        }
        public IResult Add(CarImage carImage,IFormFile formfile)
        {
            if (_carimagedal.GetAll(c=>c.CarId==carImage.CarId).Count < 5)
            {
                carImage.imagePath = FileHelper.Add(formfile);
                carImage.Date = DateTime.Now;
                _carimagedal.Add(carImage);
                return new SuccessResult(Messages.SuccessAdded);
            }
            return new ErrorResult("bir araç için 5 taneden fazla resim desteklenmiyor");
        }

        public IResult Delete(CarImage carImage)
        {
            _carimagedal.Delete(carImage);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage, bool>> filter = null)
        {
            var carimages=_carimagedal.GetAll();
            foreach (var carimage in carimages)
            {
                if (carimage.imagePath == null)
                    carimage.imagePath = "\\images\\logo.jpg";
            }
            return new SuccessDataResult<List<CarImage>>(carimages, Messages.Listed);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            var carimage = _carimagedal.GetById(id);
            if (carimage.imagePath == null)
            {
                carimage.imagePath = "\\images\\logo.jpg";
            }
            return new SuccessDataResult<CarImage>(carimage);
        }

        public IResult Update(CarImage carImage, IFormFile formFile)
        {
            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carimagedal.Get(p => p.Id == carImage.CarId).imagePath;

            carImage.imagePath = FileHelper.Update(oldPath, formFile);
            carImage.Date = DateTime.Now;
            _carimagedal.Update(carImage);
            return new SuccessResult();

        }
    }
}
