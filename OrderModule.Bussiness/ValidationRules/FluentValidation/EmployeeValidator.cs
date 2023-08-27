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
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator() 
        { 
            RuleFor(p=>p.FirstName).NotEmpty().WithMessage("İsim boş olamaz.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Soyisim boş olamaz.");
            RuleFor(p => p.Title).NotEmpty().WithMessage("Unvan boş olamaz.");
            RuleFor(p => p.TitleOfCourtesy).NotEmpty().WithMessage("Cinsiyet boş olamaz.");
            RuleFor(p => p.Address).NotEmpty().WithMessage("Adres boş olamaz.");
            RuleFor(p => p.City).NotEmpty().WithMessage("Şehir boş olamaz.");
            RuleFor(p => p.Region).NotEmpty().WithMessage("Bölge boş olamaz.");
            RuleFor(p => p.Country).NotEmpty().WithMessage("Ülke boş olamaz.");
            RuleFor(p => p.HomePhone).NotEmpty().WithMessage("Telefon numarası boş olamaz.");
            RuleFor(p => p.PostalCode).NotEmpty().WithMessage("Posta kodu boş olamaz.");

            RuleFor(p => p.LastName).MaximumLength(20).WithMessage("Soyisim 20 karakterden fazla olamaz.");
            RuleFor(p => p.FirstName).MaximumLength(10).WithMessage("İsim 10 karakterden fazla olamaz.");
            RuleFor(p => p.Title).MaximumLength(30).WithMessage("Unvan 30 karakterden fazla olamaz.");
            RuleFor(p => p.TitleOfCourtesy).MaximumLength(25).WithMessage("Cinsiyet 25 karakterden fazla olamaz.");
            RuleFor(p => p.Address).MaximumLength(60).WithMessage("Adres 60 karakterden fazla olamaz.");
            RuleFor(p => p.City).MaximumLength(15).WithMessage("Şehir 15 karakterden fazla olamaz.");
            RuleFor(p => p.Region).MaximumLength(15).WithMessage("Bölge 15 karakterden fazla olamaz.");
            RuleFor(p => p.PostalCode).MaximumLength(10).WithMessage("Posta kodu 10 karakterden fazla olamaz.");
            RuleFor(p => p.Country).MaximumLength(15).WithMessage("Ülke 15 karakterden fazla olamaz.");
            RuleFor(p => p.HomePhone).MaximumLength(24).WithMessage("Ev telefon numarası 24 karakterden fazla olamaz.");

            RuleFor(p => p.HomePhone).Must(NumericControl).WithMessage("Telefon Numarasi sayilardan oluşmalıdır.");
            RuleFor(p => p.PostalCode).Must(NumericControl).WithMessage("Posta kodu 10 karakterden fazla olamaz.");


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
