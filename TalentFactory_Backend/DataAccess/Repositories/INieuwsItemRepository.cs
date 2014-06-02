using System;
using TalentFactory_Backend.Models;
namespace TalentFactory_Backend.DataAccess.Repositories
{
    public interface INieuwsItemRepository : IGenericRepository<NieuwsItem>
    {
        System.Collections.Generic.List<TalentFactory_Backend.Models.NieuwsItem> GetLastNieuwsItems(int iAantal);
        System.Collections.Generic.List<TalentFactory_Backend.Models.NieuwsItem> GetLastNieuwsItems(int iAantal, DateTime dtBegin);
        System.Collections.Generic.List<TalentFactory_Backend.Models.NieuwsItem> GetNieuwsItems(DateTime dtBegin, DateTime dtEind);
        System.Collections.Generic.List<TalentFactory_Backend.Models.NieuwsItem> GetNieuwsItems(int iAantal, DateTime dtBegin, DateTime dtEind);
        System.Collections.Generic.List<TalentFactory_Backend.Models.NieuwsItem> GetNieuwsItems(int iStartIndex, int iEindIndex);
    }
}
