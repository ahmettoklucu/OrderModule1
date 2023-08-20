using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> GetEmployeeByEmployeerName(string firstName);
        Employee Get(int EmployeeId);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
