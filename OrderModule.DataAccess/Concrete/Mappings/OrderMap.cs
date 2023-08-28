using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable(@"Orders", "dbo");
            HasKey(x => x.OrderID);
            Property(x => x.OrderID).HasColumnName("OrderID");
            Property(x => x.EmployeeID).HasColumnName("EmployeeID");
            Property(x => x.OrderDate).HasColumnName("OrderDate");
            Property(x => x.RequiredDate).HasColumnName("RequiredDate");
            Property(x => x.ShippedDate).HasColumnName("ShippedDate");
            Property(x => x.ShipVia).HasColumnName("ShipVia");
            Property(x => x.Freight).HasColumnName("Freight");
            Property(x => x.ShipName).HasColumnName("ShipName");
            Property(x => x.ShipAddress).HasColumnName("ShipAddress");
            Property(x => x.ShipCity).HasColumnName("ShipCity");
            Property(x => x.ShipRegion).HasColumnName("ShipRegion");
            Property(x => x.ShipPostalCode).HasColumnName("ShipPostalCode");
            Property(x => x.ShipCountry).HasColumnName("ShipCountry");
            Property(x => x.Saved).HasColumnName("Saved");
            Property(x => x.SavedDate).HasColumnName("SavedDate");
            Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            Property(x => x.Updated).HasColumnName("Updated");

        }
    }
}
