using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class EmployeeMap:EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable(@"Employees", "dbo");
            HasKey(x => x.EmployeeID);
            Property(x=>x.EmployeeID).HasColumnName("EmployeeID");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.Title).HasColumnName("Title");
            Property(x => x.TitleOfCourtesy).HasColumnName("TitleOfCourtesy");
            Property(x => x.Address).HasColumnName("Address");
            Property(x => x.City).HasColumnName("City");
            Property(x => x.Region).HasColumnName("Region");
            Property(x => x.PostalCode).HasColumnName("PostalCode");
            Property(x => x.Country).HasColumnName("Country");
            Property(x => x.HomePhone).HasColumnName("HomePhone");
            Property(x => x.Extension).HasColumnName("Extension");
            Property(x => x.Notes).HasColumnName("Notes");
            Property(x => x.ReportsTo).HasColumnName("ReportsTo");
            Property(x => x.PhotoPath).HasColumnName("PhotoPath");
            Property(x => x.Saved).HasColumnName("Saved");
            Property(x => x.SavedDate).HasColumnName("SavedDate");
            Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            Property(x => x.Updated).HasColumnName("Updated");


        }
    }
}
