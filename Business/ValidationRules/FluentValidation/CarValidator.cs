using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c=>c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThan(900).When(c => c.BrandId == 1);
            RuleFor(c => c.CarName).Must(StartWithB).WithMessage("ÜRÜNLER C HARFİ İLE BAŞLAMALI");
        }

        private bool StartWithB(string arg)
        {
            return arg.StartsWith("B");
        }
    }
}
