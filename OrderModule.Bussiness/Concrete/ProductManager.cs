using OrderModule.Bussiness.Abstract;
using OrderModule.DataAccess.Abstract;
using OrderModule.DataAccess.Concrete;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal) 
        { 
            _productDal = productDal;

        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductByCategory(int CategoryId)
        {
            return _productDal.GetAll(p=>p.CategoryID == CategoryId);
        }
        public List<Product> GetProductByProductName(string producName) 
        {
            return _productDal.GetAll(p=>p.ProductName.ToLower().Contains(producName.ToLower()));
        }
    }
}
