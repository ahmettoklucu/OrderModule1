using FluentValidation;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator() 
        { 
            RuleFor(p=>p.CategoryName).NotEmpty().WithMessage("Kategori ismi boş olamaz.");
            RuleFor(p=>p.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş olamaz."); ;
            RuleFor(p=>p.CategoryName).MaximumLength(15).WithMessage("Kategori ismi 15 karekterden uzun olamaz.");
        }

    }

}
