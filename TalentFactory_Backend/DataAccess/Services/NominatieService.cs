using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_Backend.DataAccess.Repositories;
using TalentFactory_Backend.DataAccess.UOW;
using TalentFactory_Backend.Models;
using TalentFactory_Backend.Models.Engines;
using TalentFactory_Backend.ViewModels;

namespace TalentFactory_Backend.DataAccess.Services
{
    public class NominatieService : TalentFactory_Backend.DataAccess.Services.INominatieService
    {
        private TFContext context = null;
        private IGenericRepository<Award> repoAward = null;
        private INominatieRepository repoNominatie = null;        
        private IGenericRepository<JuryLid> repoJuryLid = null;        
        private IJuryKeuzeRepository repoJuryKeuze = null;
        private IUOW uow = null;
        private INominatieEngine engNominatie = null;

        public NominatieService(TFContext context, IGenericRepository<Award> repoAward, INominatieRepository repoNominatie, IGenericRepository<JuryLid> repoJuryLid ,
            IJuryKeuzeRepository repoJuryKeuze, IUOW uow, INominatieEngine engNominatie)
        {
            this.context = context;
            this.repoAward = repoAward;
            this.repoNominatie = repoNominatie;            
            this.repoJuryLid = repoJuryLid;            
            this.repoJuryKeuze = repoJuryKeuze;
            this.uow = uow;
            this.engNominatie = engNominatie;
        }

        public void PostJuryKeuze(List<JuryKeuzeAwardVM> VMs)
        {
            if (!engNominatie.CheckJuryKeuze(repoAward, repoJuryLid, VMs))
                throw new ArgumentException();

            List<JuryKeuze> lJuryKeuzes = engNominatie.ConvertJuryKeuzesVMToJuryKeuzes(VMs);
            DeleteJuryKeuzes(VMs);
            AddJuryKeuzes(lJuryKeuzes);            
        }

        /*public void AddNominee(Nominatie n)
        {
            repoNominatie.Insert(n);
        }*/

        private void AddJuryKeuzes(List<JuryKeuze> lJuryKeuzes)
        {
            foreach (JuryKeuze jk in lJuryKeuzes)
                repoJuryKeuze.Insert(jk);                
        }

        private void DeleteJuryKeuzes(List<JuryKeuzeAwardVM> VMs)
        {
            foreach (JuryKeuzeAwardVM jk in VMs)
            {
                repoJuryKeuze.VerwijderAlleJuryKeuzesVanJuryLidEnAward(jk.AwardId, jk.JuryLidId);
            }
        }
    }
}