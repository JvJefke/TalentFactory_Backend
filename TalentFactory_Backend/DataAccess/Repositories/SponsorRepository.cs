using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_CMS.Models;

namespace TalentFactory_Backend.DataAccess.Repositories
{
    public class SponsorRepository : GenericRepository<Sponsor>, TalentFactory_Backend.DataAccess.Repositories.ISponsorRepository
    {
        public SponsorRepository(TFContext context) : base(context) { }
        public List<Sponsor> GetSponsorByType(SponsorType type)
        {
            return context.Sponsor.Where(x => x.Type.ID == type.ID).ToList<Sponsor>();
        }
        public List<Sponsor> GetSponsorByType(int id)
        {
            return context.Sponsor.Where(x => x.Type.ID == id).ToList<Sponsor>();
        }
        public List<Sponsor> GetSponsorByType(SponsorType type, int iAantal)
        {
            return context.Sponsor.Where(x => x.Type.ID == type.ID).Take(iAantal).ToList<Sponsor>();
        }
        public List<Sponsor> GetSponsorByType(int id, int iAantal)
        {
            return context.Sponsor.Where(x => x.Type.ID == id).Take(iAantal).ToList<Sponsor>();
        }
    }
}