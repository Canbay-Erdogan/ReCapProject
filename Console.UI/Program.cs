using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarProcess();

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var customerList = customerManager.GetAll();

            foreach (var result in customerList.Data)
            {
                Console.WriteLine(result.CompanyName);
            }
        }

        private static void CarProcess()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car {BrandId = 1, CarName = "Audi TT update edildi", ColorId = 2, DailyPrice = 335, Description = "bir tane tt araba-updated", ModelYear = 2019 });

            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                    Console.WriteLine(item.CarName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine("___DTO ile yapılan listeleme___");
            var details = carManager.GetCarsDetail();
            foreach (var item in details.Data)
            {
                Console.WriteLine("CarName = " + item.CarName + " Marka = " + item.BrandName + " Renk = " + item.ColorName + " DailyPrice = " + item.DailyPrice);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
