using FluentValidation;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.ValidationRules.FluentValidation
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(p=>p.CustomerID).NotEmpty().WithMessage("Müşteri boş olamaz.");
            RuleFor(p => p.EmployeeID).NotEmpty().WithMessage("Yetkili boş olamaz.");
            RuleFor(p => p.ShipName).NotEmpty().WithMessage("Gemi ismi boş geçilemez");
            RuleFor(p => p.ShipAddress).NotEmpty().WithMessage("Gemi adresi boş geçilmez");
            RuleFor(p => p.ShipCity).NotEmpty().WithMessage("Gemi şehri boş geçilmez.");
            RuleFor(p => p.ShipRegion).NotEmpty().WithMessage("Gemi bölgesi boş geçilemez.");
            RuleFor(p => p.ShipPostalCode).NotEmpty().WithMessage("Gemi posta kodu boş geçilemez.");
            RuleFor(p => p.ShipCountry).NotEmpty().WithMessage("Gemi ülke boş geçilemez.");

            RuleFor(p => p.EmployeeID).NotEqual(0).WithMessage("Yetkili boş olamaz.");
            RuleFor(p => p.ShipName).MaximumLength(40).WithMessage("Gemi ismi 40 karaterden uzun olamaz.");
            RuleFor(p => p.ShipCity).MaximumLength(15).WithMessage("Gemi şehri 15 karakterden uzun olamaz.");
            RuleFor(p => p.ShipAddress).MaximumLength(60).WithName("Gemi Adresi 60 karakterden uzun olamaz.");
            RuleFor(p => p.ShipRegion).MaximumLength(15).WithMessage("Gemi bölgesi 15 karaterden uzun olamaz.");
            RuleFor(p => p.ShipPostalCode).MaximumLength(10).WithMessage("Gemi posta kodu 10 karaterden uzun olamaz.");
            RuleFor(p => p.ShipCountry).MaximumLength(15).WithMessage("Gemi ülkesi 15 karakter uzun olamaz.");

            RuleFor(p => p.ShipPostalCode).Must(NumericControl).WithMessage("Posta kodu sayilardan oluşmalıdır.");



        }
        private bool NumericControl(string arg)
        {
            bool result = false;
            Regex numericControl = new Regex("^(?=.*?[0-9]).{24,}$");
            if (numericControl.IsMatch(arg) == true)
            {
                result = true;
            }
            return result;
        }
    }
}
