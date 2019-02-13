namespace WebApp2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApp2.Models.AppDbContext>

    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebApp2.Models.AppDbContext context)
        {
        
            if (!context.Students.Any())
            {
                context.Students.Add(new Models.Student()
                {
                    Name = "Berkay",
                    SurName = "Erken",
                    StudentId = "849849",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now

                });
            }

           
        }
    }
}
