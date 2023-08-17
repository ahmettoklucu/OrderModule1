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
        private IOrderDetailDal _orderDetailDal;

        public ProductManager(IProductDal productDal) 
        { 
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            product.UnitsOnOrder=Convert.ToInt16(_orderDetailDal.GetAll(p=>p.ProductID==product.ProductID).Sum(p=>p.Quantity));    
            _productDal.Add(product);
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
