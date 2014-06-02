using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_Backend.Models;

namespace TalentFactory_Backend.DataAccess.Repositories
{
    public class NominatieRepository : GenericRepository<Nominatie>, TalentFactory_Backend.DataAccess.Repositories.INominatieRepository
    {
        public NominatieRepository(TFContext context) : base(context) { }
        public List<Nominatie> GetNominatiesByAward(Award award)
        {
            return context.Nominatie.Where(x => x.Award.ID == award.ID).ToList<Nominatie>();
        }
        public List<Nominatie> GetNominatiesByAward(int id)
        {
            return context.Nominatie.Where(x => x.Award.ID == id).ToList<Nominatie>();
        }
        public List<Nominatie> GetNominatiesByIndex(int awardId, int iStartIndex, int iAantal)
        {
            return context.Nominatie.Where(x => x.Award.ID == awardId).Skip(iStartIndex).Take(iAantal).ToList<Nominatie>();
        }
        /* public List<Nominatie> GetNominatiesByIndex(int iStartIndex, int iEindIndex)
        {
            return context.Nominatie.Skip(iStartIndex).Take(iEindIndex - iStartIndex + 1).ToList<Nominatie>();
        }*/
        
    }
}