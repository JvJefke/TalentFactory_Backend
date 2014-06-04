namespace TalentFactory_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TFContextUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nominaties", "isWinnaar", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nominaties", "isWinnaar");
        }
    }
}
