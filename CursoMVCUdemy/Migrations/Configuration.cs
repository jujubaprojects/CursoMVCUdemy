namespace CursoMVCUdemy.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CursoMVCUdemy.Data.ContextApp>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CursoMVCUdemy.Data.ContextApp";
        }

        protected override void Seed(CursoMVCUdemy.Data.ContextApp context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
