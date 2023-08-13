using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class RegionMap:EntityTypeConfiguration<Region>
    {
        public RegionMap() 
        {
            ToTable(@"Region", "dbo");
            HasKey(x => x.RegionID);
            Property(x=>x.RegionID).HasColumnName("RegionID");
            Property(x=>x.RegionDescription).HasColumnName("RegionDescription");

        
        }
    }
}
