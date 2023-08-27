using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Utilities;
using OrderModule.Bussiness.ValidationRules.FluentValidation;
using OrderModule.DataAccess.Abstract;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
           _categoryDal.Delete(category);
        }

        public Category Get(int CategoryId)
        {
          return _categoryDal.Get(P=>P.CategoryID==CategoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetCategoryByCategoryName(string categoryName)
        {
            return _categoryDal.GetAll(p => p.CategoryName.ToLower().Contains(categoryName.ToLower()));
        }

        public void Update(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            _categoryDal.Update(category);
        }
    }
}
