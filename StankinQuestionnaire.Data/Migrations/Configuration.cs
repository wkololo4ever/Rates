namespace StankinQuestionnaire.Data.Migrations
{
    using StankinQuestionnaire.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StankinQuestionnaire.Data.StankinQuestionnaireEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StankinQuestionnaire.Data.StankinQuestionnaireEntities context)
        {
            //  This method will be called after migrating to the latest version.
            context.Roles.AddOrUpdate(r => r.Name, new[] { new CustomRole { Name = "Admin" } });
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
