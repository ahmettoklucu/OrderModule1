using OrderModule.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Entities.Concrete
{
    public class Category:IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Product> Products { get; set; }
        public int? Saved { get; set; }
        public DateTime? SavedDate { get; set; }
        public int? Updated { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
