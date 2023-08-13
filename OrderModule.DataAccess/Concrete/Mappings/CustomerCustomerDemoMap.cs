using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class CustomerCustomerDemoMap: EntityTypeConfiguration<CustomerCustomerDemo>
    {
        public CustomerCustomerDemoMap() 
        {
            ToTable(@"CustomerCustomerDemo", "dbo");
            HasKey(x=>x.CustomerTypeID);
            HasKey(x=>x.CustomerID);
            Property(x=>x.CustomerID).HasColumnName("CustomerID");
            Property(x => x.CustomerTypeID).HasColumnName("CustomerTypeID");
        
        }
    }
}
