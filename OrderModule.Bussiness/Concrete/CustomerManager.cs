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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        private ICustomerCustomerDemoDal _customerDemographicDemographicDemographic;
        private IOrderDal _orderDal;
        private IOrderDetailDal _orderDetailDal;
        public CustomerManager(ICustomerDal customerDal, ICustomerCustomerDemoDal customerDemographicDemographicDemographic, IOrderDal orderDal, IOrderDetailDal orderDetailDal)
        {
            _customerDal = customerDal;
            _customerDemographicDemographicDemographic = customerDemographicDemographicDemographic;
            _orderDal = orderDal;
            _orderDetailDal = orderDetailDal;
        }

        public void Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            var orders=_orderDal.GetAll(p=>p.CustomerID == customer.CustomerID);
            foreach (var order in orders)
            {
                var orderDetails = _orderDetailDal.GetAll(p => p.OrderID == order.OrderID);
                foreach(var orderDetail in orderDetails)
                {
                    _orderDetailDal.Delete(orderDetail);
                }
                _orderDal.Delete(order);
            }
            
            var customerDemographicDemographicDemographic = _customerDemographicDemographicDemographic.GetAll(p => p.CustomerID == customer.CustomerID);
            foreach (var item in customerDemographicDemographicDemographic)
            {
                _customerDemographicDemographicDemographic.Delete(item);
            }
            _customerDal.Delete(customer);
        }

        public Customer Get(string CustomerId)
        {
            return _customerDal.Get(p=>p.CustomerID== CustomerId);
        }

        public List<Customer> GetAll()
        {
           return _customerDal.GetAll();
        }

        public List<Customer> GetCustomerByCustomerName(string companyName)
        {
            return _customerDal.GetAll(p=>p.CompanyName.ToLower().Contains(companyName.ToLower()));
        }

        public void Update(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
        }
    }
}
