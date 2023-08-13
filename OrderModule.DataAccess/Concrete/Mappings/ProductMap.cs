using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class ProductMap:EntityTypeConfiguration<Product>

    {
        public ProductMap()
        {
            ToTable(@"Products", "dbo");
            HasKey(x => x.ProductID);
            Property(x => x.ProductID).HasColumnName("ProductID");
            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.CategoryID).HasColumnName("CategoryID");
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(x => x.UnitPrice).HasColumnName("UnitPrice");
            Property(x => x.UnitsInStock).HasColumnName("UnitsInStock");
            Property(x => x.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            Property(x => x.ReorderLevel).HasColumnName("ReorderLevel");
            Property(x => x.Discontinued).HasColumnName("Discontinued");
        }

    }
}
