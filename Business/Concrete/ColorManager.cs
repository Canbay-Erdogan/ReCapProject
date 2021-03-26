using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color brand)
        {
            return new SuccessResult("Ekleme başarılı");
        }

        public IResult Delete(Color brand)
        {
            return new SuccessResult("silme başarılı");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Listeleme başarılı");
        }

        public IDataResult<Color> GetColordById(int ColorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == ColorId));
        }

        public IResult Update(Color brand)
        {
            return new SuccessResult("Update Başarılı");
        }
    }
}
