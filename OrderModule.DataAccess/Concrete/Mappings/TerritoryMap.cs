using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class TerritoryMap:EntityTypeConfiguration<Territory>
    {
        public TerritoryMap()
        {
            ToTable(@"Territories", "dbo");
            HasKey(x => x.TerritoryID);
            Property(x => x.TerritoryID).HasColumnName("TerritoryID");
            Property(x=>x.TerritoryDescription).HasColumnName("TerritoryDescription");
            Property(x => x.RegionID).HasColumnName("RegionID");

        }
    }
}
