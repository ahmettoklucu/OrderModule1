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
        List<Supplier> GetAll();
        void Add(Supplier supplier);
    }
}
