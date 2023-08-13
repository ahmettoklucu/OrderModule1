using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class ShipperMap:EntityTypeConfiguration<Shipper>
    {
        public ShipperMap()
        {
            ToTable(@"Shippers", "dbo");
            HasKey(x => x.ShipperID);
            Property(x=>x.ShipperID).HasColumnName("ShipperID");
            Property(x => x.CompanyName).HasColumnName("CompanyName");
            Property(x => x.Phone).HasColumnName("Phone");
        }
    }
}
