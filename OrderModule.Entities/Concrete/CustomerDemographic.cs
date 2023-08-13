using OrderModule.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Entities.Concrete
{
    public class CustomerDemographic:IEntity
    {
        [Key]
        public int CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }
    }
}
