using FluentValidation;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        UserValidator()
        {
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email adresi boş geçilemez.");
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullanıcı ismi boş geçilemez.");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("Telefon numarası boş geçilemez.");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Role boş geçilemez.");

            RuleFor(p => p.Phone).Must(NumericControl).WithMessage("Telefon numarasi sayilardan oluşmalıdır.");
            RuleFor(p => p.Password).Must(PasswordControl).WithMessage("Şifre büyük harf,küçük harf,sayi ve özel karakter içermelidir.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("EMail adresi email formatına uymamaktadır.");


            RuleFor(p => p.Password).MinimumLength(8).WithMessage("Şifre en az 8 karakterden oluşmalıdır.");
            RuleFor(p => p.UserName).MinimumLength(15).WithMessage("Kullanıcı ismi en az 15 karakterden oluşmalıdır.");
            RuleFor(p => p.UserName).MinimumLength(15).WithMessage("Kullanıcı ismi en az 15 karakterden oluşmalıdır.");

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
        public bool PasswordControl(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                bool result = false;
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder password = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    password.Append(hashBytes[i].ToString("x2")); // hexadecimal formatta dönüştürülen hash değerlerini sonucunu oluştur
                }
                Regex PasswordControl = new Regex("^(?=.*?[A-ZÖÜİŞĞÇ])(?=.*?[a-zöüığşç])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9ÖöÜüŞşıİĞğÇç]).{10,}$");
                if (PasswordControl.IsMatch(password.ToString()) == true)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                return result;
            }
        }
    }
}
