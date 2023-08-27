using FluentValidation;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz.");
            RuleFor(p=>p.CategoryID).NotEmpty().WithMessage("Kategori boş olamaz.");
            RuleFor(p=>p.SupplierID).NotEmpty().WithMessage("Tedarikçi boş olamaz.");
            RuleFor(p=>p.QuantityPerUnit).NotEmpty().WithMessage("Birim başına miktar boş olamaz.");
            RuleFor(p=> p.UnitPrice).NotEmpty().WithMessage("Fiyat boş geçilemez.");
            RuleFor(p=>p.UnitsInStock).NotEmpty().WithMessage("Miktar boş geçilemez.");
            RuleFor(p => p.ProductName).MaximumLength(40).WithMessage("Ürün ismi 40 Karaterden fazla olamaz.");
            RuleFor(p => p.QuantityPerUnit).MaximumLength(20).WithMessage("Birim Başına Miktar 20 fazla olamaz.");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo(Convert.ToInt16(0)).WithMessage("Stok miktari 0'dan küçük olamaz.");
            RuleFor(p=>p.UnitPrice).GreaterThanOrEqualTo(Convert.ToDecimal(0)).WithMessage("Stok miktari 0'dan küçük olamaz.");

        }
    }
}
