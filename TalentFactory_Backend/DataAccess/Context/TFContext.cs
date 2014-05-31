using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TalentFactory_CMS.Models;

namespace TalenFactory_Backend.DataAccess.Context
{
    public class TFContext : DbContext
    {
        public DbSet<Award> Award { get; set; }
        public DbSet<Contact> Contact { get; set; }
        
    }
}