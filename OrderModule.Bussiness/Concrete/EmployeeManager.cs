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
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
           _employeeDal.Delete(employee);
        }

        public Employee Get(int EmployeeId)
        {
           return _employeeDal.Get(p=>p.EmployeeID==EmployeeId);
        }

        public List<Employee> GetAll()
        {
           return _employeeDal.GetAll();
        }

        public List<Employee> GetEmployeeByEmployeerName(string firstName)
        {
           return _employeeDal.GetAll(p=>p.FirstName== firstName);
        }

        public void Update(Employee employee)
        {
           _employeeDal.Update(employee);
        }
    }
}
