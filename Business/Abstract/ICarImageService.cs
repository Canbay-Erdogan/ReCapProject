using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage,bool>> filter = null);
        IDataResult<CarImage> GetById(int id);
        IResult Add(CarImage carImage, IFormFile formFile);
        IResult Update(CarImage carImage, IFormFile formFile);
        IResult Delete(CarImage carImage);
    }
}
