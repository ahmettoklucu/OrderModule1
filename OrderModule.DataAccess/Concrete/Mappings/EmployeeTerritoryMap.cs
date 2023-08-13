using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class EmployeeTerritoryMap:EntityTypeConfiguration<EmployeeTerritory>
    {
        public EmployeeTerritoryMap()
        {
            ToTable(@"EmployeeTerritories", "dbo");
            HasKey(x => x.EmployeeID);
            HasKey(x => x.TerritoryID);
            Property(x => x.EmployeeID).HasColumnName("EmployeeID");
            Property(x => x.TerritoryID).HasColumnName("TerritoryID");
        }
    }
}
