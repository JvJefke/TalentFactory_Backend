namespace TalentFactory_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TFContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Awards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Logo = c.String(),
                        Beschrijving = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Tel = c.String(),
                        Straat_Nr = c.String(),
                        Gemeente = c.String(),
                        Postcode = c.String(),
                        Land = c.String(),
                        Foto1 = c.String(),
                        Foto2 = c.String(),
                        Foto3 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FlickrAlbums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Beschrijving = c.String(),
                        Home_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Homes", t => t.Home_ID)
                .Index(t => t.Home_ID);
            
            CreateTable(
                "dbo.HallOfFames",
                c => new
                    {
                        Jaartal = c.Int(nullable: false, identity: true),
                        HTMLInhoud = c.String(),
                    })
                .PrimaryKey(t => t.Jaartal);
            
            CreateTable(
                "dbo.Homes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Inleiding = c.String(),
                        AwardInfo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TwitterFeeds",
                c => new
                    {
                        Hashtag = c.String(nullable: false, maxLength: 128),
                        Home_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Hashtag)
                .ForeignKey("dbo.Homes", t => t.Home_ID)
                .Index(t => t.Home_ID);
            
            CreateTable(
                "dbo.JuryKeuzes",
                c => new
                    {
                        NominatieID = c.Int(nullable: false),
                        JuryLidId = c.Int(nullable: false),
                        Positie = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NominatieID, t.JuryLidId })
                .ForeignKey("dbo.JuryLids", t => t.JuryLidId, cascadeDelete: true)
                .ForeignKey("dbo.Nominaties", t => t.NominatieID, cascadeDelete: true)
                .Index(t => t.NominatieID)
                .Index(t => t.JuryLidId);
            
            CreateTable(
                "dbo.JuryLids",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Email = c.String(),
                        Functie = c.String(),
                        Bedrijf = c.String(),
                        Key = c.String(),
                        isActive = c.Boolean(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Nominaties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Voornaam = c.String(),
                        Naam = c.String(),
                        Email = c.String(),
                        Tel = c.String(),
                        Straat_Nr = c.String(),
                        Gemeente = c.String(),
                        Postcode = c.String(),
                        Land = c.String(),
                        RichtingId = c.String(maxLength: 128),
                        Beschrijving = c.String(),
                        ExtraLinks = c.String(),
                        Geslacht = c.String(),
                        AwardId = c.Int(nullable: false),
                        GeboorteDatum = c.DateTime(nullable: false),
                        Key = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Foto = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Awards", t => t.AwardId, cascadeDelete: true)
                .ForeignKey("dbo.Richtings", t => t.RichtingId)
                .Index(t => t.RichtingId)
                .Index(t => t.AwardId);
            
            CreateTable(
                "dbo.Richtings",
                c => new
                    {
                        Naam = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Naam);
            
            CreateTable(
                "dbo.NieuwsItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titel = c.String(),
                        TimeOfRelease = c.DateTime(nullable: false),
                        Foto = c.String(),
                        Inleiding = c.String(),
                        Artikel = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        HTMLInhoud = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Setups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Jaar = c.Int(nullable: false),
                        EventDateTime = c.DateTime(nullable: false),
                        EventBride = c.String(),
                        AccentKleur = c.String(),
                        Logo = c.String(),
                        Twitter = c.String(),
                        Facebook = c.String(),
                        Flickr = c.String(),
                        GooglePlus = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        SponsorTypeID = c.Int(nullable: false),
                        WebAdress = c.String(),
                        Logo = c.String(),
                        Beschrijving = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SponsorTypes", t => t.SponsorTypeID, cascadeDelete: true)
                .Index(t => t.SponsorTypeID);
            
            CreateTable(
                "dbo.SponsorTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sponsors", "SponsorTypeID", "dbo.SponsorTypes");
            DropForeignKey("dbo.JuryKeuzes", "NominatieID", "dbo.Nominaties");
            DropForeignKey("dbo.Nominaties", "RichtingId", "dbo.Richtings");
            DropForeignKey("dbo.Nominaties", "AwardId", "dbo.Awards");
            DropForeignKey("dbo.JuryKeuzes", "JuryLidId", "dbo.JuryLids");
            DropForeignKey("dbo.TwitterFeeds", "Home_ID", "dbo.Homes");
            DropForeignKey("dbo.FlickrAlbums", "Home_ID", "dbo.Homes");
            DropIndex("dbo.Sponsors", new[] { "SponsorTypeID" });
            DropIndex("dbo.Nominaties", new[] { "AwardId" });
            DropIndex("dbo.Nominaties", new[] { "RichtingId" });
            DropIndex("dbo.JuryKeuzes", new[] { "JuryLidId" });
            DropIndex("dbo.JuryKeuzes", new[] { "NominatieID" });
            DropIndex("dbo.TwitterFeeds", new[] { "Home_ID" });
            DropIndex("dbo.FlickrAlbums", new[] { "Home_ID" });
            DropTable("dbo.SponsorTypes");
            DropTable("dbo.Sponsors");
            DropTable("dbo.Setups");
            DropTable("dbo.Pages");
            DropTable("dbo.NieuwsItems");
            DropTable("dbo.Richtings");
            DropTable("dbo.Nominaties");
            DropTable("dbo.JuryLids");
            DropTable("dbo.JuryKeuzes");
            DropTable("dbo.TwitterFeeds");
            DropTable("dbo.Homes");
            DropTable("dbo.HallOfFames");
            DropTable("dbo.FlickrAlbums");
            DropTable("dbo.Contacts");
            DropTable("dbo.Awards");
        }
    }
}
