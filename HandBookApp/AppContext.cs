namespace HandBookApp
{
    using HandBookApp.Pages;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

       
         public DbSet<City> Cities { get; set; }
         public DbSet<Person> People { get; set; }
      
    }
    
}