namespace codixU.Migrations
{
    using codixU.Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<codixU.Models.AuthorizeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(codixU.Models.AuthorizeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            IList<Roles> roles = new List<Roles>();
            roles.Add(new Roles { RoleName = "Admin" });
            roles.Add(new Roles { RoleName = "Educator" });
            roles.Add(new Roles { RoleName = "Student" });
            context.Roles.AddRange(roles);
            base.Seed(context);

        }
        
    }
    
}
