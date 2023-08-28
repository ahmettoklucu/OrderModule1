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
            ValidationTool.Validate(new SupplierValidator(), supplier);
            _supplierDal.Add(supplier);
        }

        public void Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
        }

        public Supplier Get(int SupplierId)
        {
            return _supplierDal.Get(p=>p.SupplierID==SupplierId);
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetAll();
        }

        public List<Supplier> GetSupplierByCompanyName(string categoryName)
        {
            return _supplierDal.GetAll(p => p.CompanyName.ToLower().Contains(categoryName.ToLower()));
        }

        public void Update(Supplier supplier)
        {
            ValidationTool.Validate(new SupplierValidator(), supplier);
           _supplierDal.Update(supplier);
        }
    }
}
