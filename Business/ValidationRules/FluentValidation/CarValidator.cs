using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>

    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("0 degeri olamaz");
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(75).When(c => c.BrandId == 4);
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("araç adı 2 karekterden fazla olsun");

           // RuleFor(c => c.CarName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            bool result = arg.StartsWith("A");
            return result;
        }
    }
}
