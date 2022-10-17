using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");

            RuleFor(x => x.ProductName).MaximumLength(20).WithMessage("Ürün adı en fazla 20 karakter olabilir");

            RuleFor(x => x.ProductName).MinimumLength(5).WithMessage("Ürün adı en az 5 karakter olabilir");
        }
    }
}
