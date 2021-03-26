using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DataContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (DataContext context = new DataContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto { CarName = c.CarName, DailyPrice = c.DailyPrice, BrandName = br.Name, ColorName = cl.Name };
                return result.ToList();
            }
        }
    }
}
