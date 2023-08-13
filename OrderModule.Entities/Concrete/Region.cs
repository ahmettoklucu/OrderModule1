using OrderModule.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Entities.Concrete
{
    public class Region:IEntity
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}
