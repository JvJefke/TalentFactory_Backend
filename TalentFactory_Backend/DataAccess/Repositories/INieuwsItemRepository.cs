using System;
using TalentFactory_CMS.Models;
namespace TalentFactory_Backend.DataAccess.Repositories
{
    public interface INieuwsItemRepository : IGenericRepository<NieuwsItem>
    {
        System.Collections.Generic.List<TalentFactory_CMS.Models.NieuwsItem> GetLastNieuwsItems(int iAantal);
        System.Collections.Generic.List<TalentFactory_CMS.Models.NieuwsItem> GetLastNieuwsItems(int iAantal, DateTime dtBegin);
        System.Collections.Generic.List<TalentFactory_CMS.Models.NieuwsItem> GetNieuwsItems(DateTime dtBegin, DateTime dtEind);
        System.Collections.Generic.List<TalentFactory_CMS.Models.NieuwsItem> GetNieuwsItems(int iAantal, DateTime dtBegin, DateTime dtEind);
        System.Collections.Generic.List<TalentFactory_CMS.Models.NieuwsItem> GetNieuwsItems(int iStartIndex, int iEindIndex);
    }
}
