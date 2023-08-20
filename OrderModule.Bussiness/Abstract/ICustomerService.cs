using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetCustomerByCustomerName(string companyName);
        Customer Get(string CustomerId);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
