
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable(@"Customers", "dbo");
            HasKey(x=>x.CustomerID);
            Property(x => x.CustomerID).HasColumnName("CustomerID");
            Property(x => x.CompanyName).HasColumnName("CompanyName");
            Property(x => x.ContactName).HasColumnName("ContactName");
            Property(x => x.ContactTitle).HasColumnName("ContactTitle");
            Property(x => x.Address).HasColumnName("Address");
            Property(x => x.City).HasColumnName("City");
            Property(x => x.Region).HasColumnName("Region");
            Property(x => x.PostalCode).HasColumnName("PostalCode");
            Property(x => x.Country).HasColumnName("Country");
            Property(x => x.Phone).HasColumnName("Phone");
            Property(x => x.Fax).HasColumnName("Fax");
            Property(x => x.Saved).HasColumnName("Saved");
            Property(x => x.SavedDate).HasColumnName("SavedDate");
            Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            Property(x => x.Updated).HasColumnName("Updated");
        }
    }
}
