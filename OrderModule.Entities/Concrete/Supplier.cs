using OrderModule.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Entities.Concrete
{
    public class Supplier:IEntity
    {
        public int SupplierID { get; set; }
        public string  CompanyName { get; set; }
        public string ContactName { get; set;}
        public string ContactTitle { get; set; }
        public string Address { get; set;} 
        public string City { get; set;}
        public string Region { get; set;}
        public string PostalCode { get; set;}
        public string Country { get; set;}
        public string Phone { get; set;}
        public string Fax { get; set;}
        public string HomePage { get; set;}
        public int Saved { get; set; }
        public DateTime SavedDate { get; set; }
        public int Updated { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
