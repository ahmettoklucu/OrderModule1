using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface IEmployeeTerritoryService

    {
        List<EmployeeTerritory> SingleEmployee(int employeId);
        void Delete(EmployeeTerritory employeeTerritory);
    }
}
