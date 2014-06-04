using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.ViewModels;

namespace TalentFactory_Backend.Models.Engines
{
    public class NominatieEngine
    {
        public Boolean CheckJuryKeuze(List<JuryKeuzeAwardVM> VMs)
        {
            return false;
        }

        public List<JuryKeuze> ConvertJuryKeuzesVMToJuryKeuzes(List<JuryKeuzeAwardVM> VMs)
        {
            return null;
        }
    }
}