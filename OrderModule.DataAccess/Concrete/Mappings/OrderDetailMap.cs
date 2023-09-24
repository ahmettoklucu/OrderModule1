using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreamwork.Northwind.DataAccess.Concrete.EntityFreamwork.Mappings
{
    public class OrderDetailMap:EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable(@"OrderDetails", "dbo");
            HasKey(x => x.OrderID);
            HasKey(x => x.ProductID);
            Property(x => x.ProductID).HasColumnName("ProductID");
            Property(x=>x.OrderID).HasColumnName("OrderID");
            Property(x => x.UnitPrice).HasColumnName("UnitPrice");
            Property(x => x.Quantity).HasColumnName("Quantity");
            Property(x => x.Discount).HasColumnName("Discount");
            Property(x => x.Saved).HasColumnName("Saved");
            Property(x => x.SavedDate).HasColumnName("SavedDate");
            Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            Property(x => x.Updated).HasColumnName("Updated");
        }
    }
}
