using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().WithMessage("Ürün isimi boş geçilemez");
            RuleFor(p=>p.ProductId).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Stok adedi boş geçilemez");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Birim adedi boş geçilemez");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Fiyat boş geçilemez");

            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Fiyat sıfırdan büyük olmalı");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0).WithMessage("Stok adedi sıfırdan büyük olmalı");
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);
        }
    }
}
