using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_Backend.Models;

namespace TalentFactory_Backend.DataAccess.Repositories
{
    public class NieuwsItemRepository : GenericRepository<NieuwsItem>, TalentFactory_Backend.DataAccess.Repositories.INieuwsItemRepository
    {
        public NieuwsItemRepository(TFContext context) : base(context) { }

        public List<NieuwsItem> GetLastNieuwsItems(int iAantal)
        {
            return context.NieuwsItem.Where(x => x.TimeOfRelease <= DateTime.Now).OrderByDescending(x => x.TimeOfRelease).Take(iAantal).ToList<NieuwsItem>();
        }
        public List<NieuwsItem> GetLastNieuwsItems(int iAantal, DateTime dtBegin)
        {
            return context.NieuwsItem.Where(x => x.TimeOfRelease <= DateTime.Now && x.TimeOfRelease >= dtBegin).OrderByDescending(x => x.TimeOfRelease).Take(iAantal).ToList<NieuwsItem>();
        }
        public List<NieuwsItem> GetNieuwsItems(int iAantal, DateTime dtBegin, DateTime dtEind)
        {
            return context.NieuwsItem.Where(x => x.TimeOfRelease <= DateTime.Now && x.TimeOfRelease >= dtBegin && x.TimeOfRelease <= dtEind).OrderByDescending(x => x.TimeOfRelease).Take(iAantal).ToList<NieuwsItem>();
        }
        public List<NieuwsItem> GetNieuwsItems(DateTime dtBegin, DateTime dtEind)
        {
            return context.NieuwsItem.Where(x => x.TimeOfRelease <= DateTime.Now && x.TimeOfRelease >= dtBegin && x.TimeOfRelease <= dtEind).ToList<NieuwsItem>();
        }
        public List<NieuwsItem> GetNieuwsItems(int iStartIndex, int iAantal)
        {
            return context.NieuwsItem.Where(x => x.TimeOfRelease <= DateTime.Now).OrderByDescending(x => x.TimeOfRelease).Skip(iStartIndex).Take(iAantal).ToList<NieuwsItem>();
        }
        /*public List<NieuwsItem> GetNieuwsItems(int iStartIndex, int iEindIndex)
        {
            return context.NieuwsItem.Where(x => x.TimeOfRelease <= DateTime.Now).OrderByDescending(x => x.TimeOfRelease).Skip(iStartIndex).Take(iEindIndex - iStartIndex + 1).ToList<NieuwsItem>();
        }*/
    }
}