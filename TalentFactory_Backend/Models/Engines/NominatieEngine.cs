using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Repositories;
using TalentFactory_Backend.ViewModels;

namespace TalentFactory_Backend.Models.Engines
{
    public class NominatieEngine : TalentFactory_Backend.Models.Engines.INominatieEngine
    {

        public List<JuryKeuze> ConvertJuryKeuzesVMToJuryKeuzes(List<JuryKeuzeAwardVM> VMs)
        {
            List<JuryKeuze> lResult = null;

            foreach (JuryKeuzeAwardVM vm in VMs)
            {
                foreach(NominatiePositie n in vm.NominatiesPositie)
                {
                    lResult.Add(new JuryKeuze(){JuryLidId = vm.JuryLidId, NominatieID = n.NominatieId, Positie = n.Positie});
                }
            }

            return lResult;
        }

        public bool CheckJuryKeuze(IGenericRepository<Award> repoAward, IGenericRepository<JuryLid> repoJuryLid, List<JuryKeuzeAwardVM> VMs)
        {
            if (VMs == null || VMs.Count <= 0)
                return false;

            foreach (JuryKeuzeAwardVM vm in VMs)
            {
                if (vm.NominatiesPositie == null || vm.NominatiesPositie.Count > 3 || vm.NominatiesPositie.Count == 0)
                    return false;
                if (repoAward.GetByID(vm.AwardId) == null)
                    return false;
                if (repoJuryLid.GetByID(vm.JuryLidId) == null)
                    return false;
            }

            return true;
        }
    }
}