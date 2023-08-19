using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface ISupplierService
    {
        Supplier Get(int SupplierId);
        List<Supplier> GetAll();
        List<Supplier> GetSupplierBySupplierName(string categoryName);
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
    }
}
