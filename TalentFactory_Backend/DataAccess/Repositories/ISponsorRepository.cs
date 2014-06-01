using System;
using TalentFactory_CMS.Models;
namespace TalentFactory_Backend.DataAccess.Repositories
{
    public interface ISponsorRepository : IGenericRepository<Sponsor>
    {
        System.Collections.Generic.List<TalentFactory_CMS.Models.Sponsor> GetSponsorByType(int id);
        System.Collections.Generic.List<TalentFactory_CMS.Models.Sponsor> GetSponsorByType(int id, int iAantal);
        System.Collections.Generic.List<TalentFactory_CMS.Models.Sponsor> GetSponsorByType(TalentFactory_CMS.Models.SponsorType type);
        System.Collections.Generic.List<TalentFactory_CMS.Models.Sponsor> GetSponsorByType(TalentFactory_CMS.Models.SponsorType type, int iAantal);
    }
}
