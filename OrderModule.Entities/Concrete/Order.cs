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
    public class Order:IEntity
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set;}
        public string ShipCity { get; set;}
        public string ShipRegion { get; set;}
        public string ShipPostalCode { get; set;}
        public string ShipCountry { get; set;}
        [ForeignKey("CustomerID")]
        public Customer Customers { get; set;}
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        public int Saved { get; set; }
        public DateTime SavedDate { get; set; }
        public int Updated { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
