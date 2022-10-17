using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Müşteri adı boş geçilemez");
            RuleFor(x => x.CustomerName).MaximumLength(20).WithMessage("Müşteri adı en fazla 20 karakter olabilir");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Müşteri adı en az 5 karakter olabilir");

        }
    
    }
}
