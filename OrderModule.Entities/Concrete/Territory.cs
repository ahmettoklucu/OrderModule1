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
    public class Territory:IEntity
    {
        [Key]
        public int TerritoryID { get; set; }
        public string TerritoryDescription { get; set;}
        public int RegionID { get; set;}
        [ForeignKey("RegionID")]
        public Region Region { get; set; }
    }
}
