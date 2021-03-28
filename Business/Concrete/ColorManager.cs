using Business.Abstract;
using Business.Constants;
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
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult Delete(Color brand)
        {
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.Listed);
        }

        public IDataResult<Color> GetColordById(int ColorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == ColorId));
        }

        public IResult Update(Color brand)
        {
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}
