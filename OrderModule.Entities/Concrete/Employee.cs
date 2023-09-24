﻿using OrderModule.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Entities.Concrete
{
    public class Employee:IEntity
    {
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public string? Address { get; set;}
        public string? City { get; set;}
        public string? Region { get; set;}
        public string? PostalCode { get; set;}
        public string? Country { get; set;}
        public string? HomePhone { get; set;}
        public string? Extension { get; set;}
        public string? Notes { get; set;}
        public int? ReportsTo { get; set; }
        public string? PhotoPath { get; set;}
        public int? Saved { get; set; }
        public DateTime? SavedDate { get; set; }
        public int? Updated { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
