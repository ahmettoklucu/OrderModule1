using FluentValidation;
using FluentValidation.Validators;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.ValidationRules.FluentValidation
{
    public class SupplierValidator:AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(p=>p.CompanyName).NotEmpty().WithMessage("Şirket ismi boş olamaz.");
            RuleFor(p => p.ContactName).NotEmpty().WithMessage("Yetkili ismi boş olamaz.");
            RuleFor(p => p.ContactTitle).NotEmpty().WithMessage("Yetkili unvanı boş olamaz.");
            RuleFor(p => p.Address).NotEmpty().WithMessage("Adres boş olamaz.");
            RuleFor(p => p.City).NotEmpty().WithMessage("Şehir ismi boş olamaz.");
            RuleFor(p => p.Region).NotEmpty().WithMessage("Bölge boş olamaz.");
            RuleFor(p => p.PostalCode).NotEmpty().WithMessage("Posta kodu boş olamaz.");
            RuleFor(p => p.Country).NotEmpty().WithMessage("Ülke ismi boş olamaz.");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("Telefon numarası boş olamaz.");
            RuleFor(p => p.Fax).NotEmpty().WithMessage("Fax numarası boş olamaz.");

            RuleFor(p => p.CompanyName).MaximumLength(40).WithMessage("Şirket ismi 40 karaterden uzun olamaz.");
            RuleFor(p => p.ContactName).MaximumLength(30).WithMessage("Yetkili ismi 30 karakterden uzun olamaz.");
            RuleFor(p => p.Address).MaximumLength(60).WithMessage("Adres 60 karakterden uzun olamaz.");
            RuleFor(p => p.ContactTitle).MaximumLength(30).WithMessage("Yetkili unvanı 30 karakterden uzun olamaz.");
            RuleFor(p => p.City).MaximumLength(15).WithMessage("Şehir 15 karakterden uzun olamaz;");
            RuleFor(p => p.Region).MaximumLength(15).WithMessage("Bölge 15 karakterden uzun olamaz.");
            RuleFor(p => p.PostalCode).MaximumLength(10).WithMessage("Posta kodu 10 karakterden fazla olamaz.");
            RuleFor(p => p.Country).MaximumLength(15).WithMessage("Ülke 15 karakterden fazla olamaz.");
            RuleFor(p => p.Phone).MaximumLength(24).WithMessage("Telefon numarası 24 karakterden fazla olamaz.");

            RuleFor(p => p.Phone).Must(NumericControl).WithMessage("Telefon numarası sayılardan oluşmalıdır.");
            RuleFor(p => p.PostalCode).Must(NumericControl).WithMessage("Posta kodu sayılardan oluşmalıdır.");

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
