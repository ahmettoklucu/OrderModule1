using OrderModule.DataAccess.Abstract;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.DataAccess.Concrete
{
    public class EfEmployeeTerritoryDal:EfEntityRepositoryBase<EmployeeTerritory,OrderModuleContext>,IEmployeeTerritoryDal
    {
    }
}
