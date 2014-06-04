using System;
using TalentFactory_Backend.Models;
namespace TalentFactory_Backend.DataAccess.Repositories
{
    public interface IJuryKeuzeRepository : IGenericRepository<JuryKeuze>
    {
        void VerwijderAlleJuryKeuzesVanJuryLidEnAward(int JuryID, int AwardID);
    }
}
