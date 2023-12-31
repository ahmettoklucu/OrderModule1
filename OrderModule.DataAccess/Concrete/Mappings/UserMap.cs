﻿using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.DataAccess.Concrete.Mappings
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap() 
        {
            ToTable(@"Users", "dbo");
            HasKey(x => x.Id);
            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Phone).HasColumnName("Phone");
            Property(x=>x.Password).HasColumnName("Password");
            Property(x=>x.RoleId).HasColumnName("RoleId");
            Property(x => x.Status).HasColumnName("Status");
        }
    }
}
