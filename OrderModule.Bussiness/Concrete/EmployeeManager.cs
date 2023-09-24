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
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        private IEmployeeTerritoryDal _employeeTerritory;
        private IOrderDal _orderDal;
        private IOrderDetailDal _orderDetailDal;
        public EmployeeManager(IEmployeeDal employeeDal, IEmployeeTerritoryDal employeeTerritoryDal, IOrderDetailDal orderDetailDal,IOrderDal orderDal)
        {
            _employeeDal = employeeDal;
            _employeeTerritory = employeeTerritoryDal;
            _orderDetailDal = orderDetailDal;
            _orderDal = orderDal;

        }
        public void Add(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(),employee);
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            var employeeTerries= _employeeTerritory.GetAll(p=>p.EmployeeID==employee.EmployeeID);
            var order = _orderDal.GetAll(p => p.EmployeeID == employee.EmployeeID);
            foreach (var item in order)
            {
                var orderDetail = _orderDetailDal.GetAll(p => p.OrderID == item.OrderID);
                foreach (var item1 in orderDetail)
                {
                    _orderDetailDal.Delete(item1);
                }
                _orderDal.Delete(item);
            }
            foreach (var item2 in employeeTerries)
            {
                _employeeTerritory.Delete(item2);
            }
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
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.Update(employee);
        }
    }
}
