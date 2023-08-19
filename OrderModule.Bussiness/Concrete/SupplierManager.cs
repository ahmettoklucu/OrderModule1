using OrderModule.Bussiness.Abstract;
using OrderModule.DataAccess.Abstract;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class SupplierManager:ISupplierService
    {
        private ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal
            )
        {
            _supplierDal = supplierDal;
        }

        public void Add(Supplier supplier)
        {
           _supplierDal.Add(supplier);
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetAll();
        }
    }
}
