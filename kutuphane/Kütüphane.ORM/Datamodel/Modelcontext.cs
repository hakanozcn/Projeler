using System;
using System.Collections.Generic;
using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;


namespace Kütüphane.ORM.Datamodel
{
    public class Modelcontext : DbContext
    {

        public Modelcontext() : base("DBConnection")
        {  }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Writers> Writers { get; set; }
  
    }
 
        
       

    

   
}