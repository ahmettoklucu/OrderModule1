﻿using OrderModule.Bussiness.Abstract;
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
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
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
            _customerDal.Update(customer);
        }
    }
}