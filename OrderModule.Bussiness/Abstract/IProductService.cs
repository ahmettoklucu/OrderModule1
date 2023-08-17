using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductByCategory(int CategoryId);
        List<Product> GetProductByProductName(string producName);
        void  Add(Product product);
    }
}
