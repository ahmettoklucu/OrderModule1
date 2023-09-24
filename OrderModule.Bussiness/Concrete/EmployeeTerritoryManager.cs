using OrderModule.Bussiness.Abstract;
using OrderModule.DataAccess.Abstract;
using OrderModule.DataAccess.Concrete;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class EmployeeTerritoryManager : IEmployeeTerritoryService

    {
        private IEmployeeTerritoryDal _employeeTerritoryDal;
        public EmployeeTerritoryManager(IEmployeeTerritoryDal employeeTerritoryDal)
        {
            _employeeTerritoryDal = employeeTerritoryDal;
        }
        public void Delete(EmployeeTerritory employeeTerritory)
        {
            _employeeTerritoryDal.Delete(employeeTerritory);
        }

        public List<EmployeeTerritory> SingleEmployee(int employeId)
        {
           return _employeeTerritoryDal.GetAll(p=>p.EmployeeID==employeId);
        }
    }
}
