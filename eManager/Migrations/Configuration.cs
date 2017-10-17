namespace eManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using eManager.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Infraestructure.DeparmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.Infraestructure.DeparmentDb context)
        {
            context.Employees2.AddOrUpdate(
                    emp=> emp.id,
                    new Employee { name="Kike"},
                    new Employee { name = "Sandy" },
                    new Employee { name = "Jose" }
                );
            context.Deparments2.AddOrUpdate(
                    dep=> dep.id,
                    new Deparment { name="IT" },
                    new Deparment { name="QFB"},
                    new Deparment { name="human resources"}
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
