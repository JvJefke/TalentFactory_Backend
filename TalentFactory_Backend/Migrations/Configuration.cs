namespace TalentFactory_Backend.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TalentFactory_Backend.DataAccess.Context.TFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TalentFactory_Backend.DataAccess.Context.TFContext context)
        {
            
        }
    }
}
