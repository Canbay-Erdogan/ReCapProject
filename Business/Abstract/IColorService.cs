using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IResult Add(Color brand);
        IResult Update(Color brand);
        IResult Delete(Color brand);
        IDataResult<Color> GetColordById(int ColorId);
    }
}
