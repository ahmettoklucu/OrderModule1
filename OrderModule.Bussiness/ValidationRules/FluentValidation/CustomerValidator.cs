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
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator() 
        { 
            RuleFor(p=>p.CompanyName).NotEmpty().WithMessage("Şirket ismi boş olamaz.");
            RuleFor(p => p.ContactName).NotEmpty().WithMessage("Kişi ismi boş olamaz.");
            RuleFor(p => p.ContactTitle).NotEmpty().WithMessage("Kişi unvanı boş olamaz.");
            RuleFor(p => p.Address).NotEmpty().WithMessage("Adres boş olamaz.");
            RuleFor(p => p.City).NotEmpty().WithMessage("Şehir boş olamaz.");
            RuleFor(p => p.Region).NotEmpty().WithMessage("Bölge boş olamaz.");
            RuleFor(p => p.PostalCode).NotEmpty().WithMessage("Posta kodu boş olamaz.");
            RuleFor(p => p.Country).NotEmpty().WithMessage("Şehir boş olamaz.");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("Telefon numarasi boş geçilemez");
            RuleFor(p => p.Fax).NotEmpty().WithMessage("Fax boş geçilemez.");
            RuleFor(p => p.CustomerID).NotEmpty().WithMessage("Şirket Kodu Boş geçilemez.");

            RuleFor(p => p.CustomerID).MinimumLength(5).WithMessage("Şirket Kodu 5 karekterden az olamaz.");
            RuleFor(p => p.CustomerID).MaximumLength(5).WithMessage("Şirket Kodu 5 karekterden fazla olamaz.");
            RuleFor(p => p.CompanyName).MaximumLength(40).WithMessage("Şirket ismi 40 karakterden fazla olamaz.");
            RuleFor(p => p.ContactName).MaximumLength(30).WithMessage("Kişi ismi 30 karakterden fazla olamaz.");
            RuleFor(p => p.ContactTitle).MaximumLength(30).WithMessage("Kişi unvanı 30 karakterden fazla olamaz.");
            RuleFor(p => p.Address).MaximumLength(60).WithMessage("Adres 60 karakterden fazla olamaz.");
            RuleFor(p => p.City).MaximumLength(15).WithMessage("Şehir 15 karakterden fazla olamaz.");
            RuleFor(p => p.Region).MaximumLength(15).WithMessage("Bölge 15 karakterden fazla olamaz.");
            RuleFor(p => p.PostalCode).MaximumLength(10).WithMessage("Posta kodu 10 karakterden fazla olamaz.");
            RuleFor(p => p.Country).MaximumLength(15).WithMessage("Şehir 15 karakterden fazla olamaz.");
            RuleFor(p => p.Phone).MaximumLength(24).WithMessage("Telefon numarasi 24 karakterden fazla olamaz.");
            RuleFor(p => p.Fax).MaximumLength(24).WithMessage("Fax 24 karakterden fazla olamaz.");

            RuleFor(p => p.Fax).Must(NumericControl).WithMessage("Fax Numarasi sayilardan oluşmalıdır.");
            RuleFor(p => p.Phone).Must(NumericControl).WithMessage("Telefon Numarasi sayilardan oluşmalıdır.");
            RuleFor(p => p.PostalCode).Must(NumericControl).WithMessage("Posta kodu sayilardan oluşmalıdır.");


        }
        private bool NumericControl(string arg)
        {
            bool result = false;
            Regex numericControl = new Regex("^(?=.*?[0-9]).{24,}$");
            if(numericControl.IsMatch(arg)==true)     
            {
                result = true;
            }
            return result;
        }
    }
}
