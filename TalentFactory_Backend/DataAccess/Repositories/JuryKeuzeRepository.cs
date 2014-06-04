using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_Backend.Models;
using System.Data.Entity;
using EntityFramework.Extensions;

namespace TalentFactory_Backend.DataAccess.Repositories
{
    public class JuryKeuzeRepository : GenericRepository<JuryKeuze>, TalentFactory_Backend.DataAccess.Repositories.IJuryKeuzeRepository
    {
        public JuryKeuzeRepository(TFContext context) : base(context) { }
        public void VerwijderAlleJuryKeuzesVanJuryLidEnAward(int JuryID, int AwardID)
        {
            context.JuryKeuze.Where(x => x.JuryLidId == JuryID && x.Nominatie.AwardId == AwardID).Delete();
        }
    }
}