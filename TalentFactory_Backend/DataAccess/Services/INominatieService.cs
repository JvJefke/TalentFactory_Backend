using System;
namespace TalentFactory_Backend.DataAccess.Services
{
    public interface INominatieService
    {
        void PostJuryKeuze(System.Collections.Generic.List<TalentFactory_Backend.ViewModels.JuryKeuzeAwardVM> VMs);
    }
}
