using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TalentFactory_Backend.Models;

namespace TalentFactory_Backend.DataAccess.Context
{
    public class TFContext : DbContext
    {
        public DbSet<Award> Award { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<FlickrAlbum> FlickrAlbum { get; set; }
        public DbSet<HallOfFame> HallOfFame { get; set; }
        public DbSet<Home> Home { get; set; }
        public DbSet<JuryKeuze> JuryKeuze { get; set; }
        public DbSet<JuryLid> JuryLid { get; set; }
        public DbSet<NieuwsItem> NieuwsItem { get; set; }
        public DbSet<Nominatie> Nominatie { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<Richting> Richting { get; set; }
        public DbSet<Setup> Setup { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<SponsorType> SponsorType { get; set; }
        public DbSet<TwitterFeed> TwitterFeed { get; set; }        
        
    }
}