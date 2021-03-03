using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotEmpty();
            RuleFor(c => c.CompanyName).MinimumLength(2);
            RuleFor(c => c.CompanyName).Must(StartWithB).WithMessage("ŞİRKET ADI F HARFİ İLE BAŞLAMALI");
        }

        private bool StartWithB(string arg)
        {
            return arg.StartsWith("F");
        }
    }
}
