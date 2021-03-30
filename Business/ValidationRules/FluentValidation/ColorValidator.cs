using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Boş renk olamaz");
            RuleFor(c => c.Id).Empty().WithMessage("id degeri veremezsin");

            RuleFor(c => c.Name).Must(StarsWithC).WithMessage("Color C- ile başlamalıdır");
        }

        private bool StarsWithC(string arg)
        {
            return arg.StartsWith("C-");
        }
    }
}
