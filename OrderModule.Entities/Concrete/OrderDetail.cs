using OrderModule.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Entities.Concrete
{
    public class OrderDetail:IEntity
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public bool Discount { get; set; }
        public int? Saved { get; set; }
        public DateTime? SavedDate { get; set; }
        public int? Updated { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
