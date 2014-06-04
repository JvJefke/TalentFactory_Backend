namespace TalentFactory_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TFContextUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "LocatieNaam", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "LocatieNaam");
        }
    }
}
