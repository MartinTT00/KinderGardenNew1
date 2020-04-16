namespace DataStructer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KinderGardenNew1DBContext : DbContext
    {
        // Your context has been configured to use a 'KinderGardenNew1DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataStructer.KinderGardenNew1DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KinderGardenNew1DBContext' 
        // connection string in the application configuration file.
        public KinderGardenNew1DBContext()
            : base("name=KinderGardenNew1DBContext")
        {
        }
        DbSet<Kid> Kids { get; set; }
        DbSet<Activity> Activities { get; set; }
        DbSet<Parent> Parents { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Group> Groups { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}