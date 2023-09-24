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
    public class EmployeeTerritory:IEntity
    {
        [Key]
        public int EmployeeID { get; set; }
        [Key]
        public string TerritoryID { get; set; }
       
    }
}
