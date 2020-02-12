using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JK651914_MIS4200SD.Models;
using System.Data.Entity;


namespace JK651914_MIS4200SD.Models.DAL
{
  
        public class MIS4200Context : DbContext // inherits from DbContext
        {
            public MIS4200Context() : base("name=DefaultConnection")
            {
                // this method is a 'constructor' and is called when a new context is created
                // the base attribute says which connection string to use
            }
            // Include each object here. The value inside <> is the name of the class,
            // the value outside should generally be the plural of the class name
            // and is the name used to reference the entity in code
            public DbSet<Car> Cars { get; set; }
            public DbSet<Owner> Owners { get; set; }
            public DbSet<OrderDetails> Order { get; set; }

        }
    
}