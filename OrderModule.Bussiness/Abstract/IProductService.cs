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
        Product Get(int ProductId);
        List<Product> GetAll();
        List<Product> GetProductByCategory(int CategoryId);
        List<Product> GetProductBySupplier(int SupplierId);
        List<Product> GetProductByProductName(string producName);
        void  Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
