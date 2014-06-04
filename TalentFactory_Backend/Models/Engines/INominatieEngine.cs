using System;
using System.Collections.Generic;
using TalentFactory_Backend.DataAccess.Repositories;
using TalentFactory_Backend.ViewModels;
namespace TalentFactory_Backend.Models.Engines
{
    public interface INominatieEngine
    {
        bool CheckJuryKeuze(IGenericRepository<Award> repoAward, IGenericRepository<JuryLid> repoJuryLid, System.Collections.Generic.List<TalentFactory_Backend.ViewModels.JuryKeuzeAwardVM> VMs);
        List<JuryKeuze> ConvertJuryKeuzesVMToJuryKeuzes(List<JuryKeuzeAwardVM> VMs);
    }
}
