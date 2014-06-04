using System;
using TalentFactory_Backend.Models;
namespace TalentFactory_Backend.DataAccess.Repositories
{
    public interface ISponsorRepository : IGenericRepository<Sponsor>
    {
        System.Collections.Generic.List<TalentFactory_Backend.Models.Sponsor> GetSponsorByType(int id);
        System.Collections.Generic.List<TalentFactory_Backend.Models.Sponsor> GetSponsorByType(int id, int iAantal);
        System.Collections.Generic.List<TalentFactory_Backend.Models.Sponsor> GetSponsorByType(TalentFactory_Backend.Models.SponsorType type);
        System.Collections.Generic.List<TalentFactory_Backend.Models.Sponsor> GetSponsorByType(TalentFactory_Backend.Models.SponsorType type, int iAantal);
        System.Collections.Generic.List<Sponsor> GetAlleSponsorsMetInclude();
    }
}
