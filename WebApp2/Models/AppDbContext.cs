using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("StuConn")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>("StuConn"));
        }



            public DbSet <Student> Students { get; set; }
            public DbSet <Teacher> Teachers { get; set; }
            public DbSet <ClassRoom> ClassRooms { get; set; }

        

    }
    

    
}
