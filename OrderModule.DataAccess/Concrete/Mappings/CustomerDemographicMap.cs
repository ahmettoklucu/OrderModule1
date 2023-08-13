
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class CustomerDemographicMap:EntityTypeConfiguration<CustomerDemographic>
    {
        public CustomerDemographicMap()
        {
            ToTable(@"CustomerDemographics", "dbo");
            HasKey(x => x.CustomerTypeId);
            Property(x=>x.CustomerTypeId).HasColumnName("CustomerTypeID");
            Property(x => x.CustomerDesc).HasColumnName("CustomerDesc");
        }
    }
}
