using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetCategoryByCategoryName(string categoryName);
        Category Get(int CategoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
