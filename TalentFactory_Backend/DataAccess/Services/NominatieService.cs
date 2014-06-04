using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_Backend.DataAccess.Repositories;
using TalentFactory_Backend.DataAccess.UOW;
using TalentFactory_Backend.Models;
using TalentFactory_Backend.ViewModels;

namespace TalentFactory_Backend.DataAccess.Services
{
    public class NominatieService
    {
        private TFContext context = null;
        private IGenericRepository<Award> repoAward = null;
        private INominatieRepository repoNominatie = null;        
        private IGenericRepository<JuryLid> repoJuryLid = null;        
        private IGenericRepository<JuryKeuze> repoJuryKeuze = null;
        private IUOW uow;

        public NominatieService(TFContext context, IGenericRepository<Award> repoAward, INominatieRepository repoNominatie, IGenericRepository<JuryLid> repoJuryLid , 
            IGenericRepository<JuryKeuze> repoJuryKeuze, IUOW uow)
        {
            this.context = context;
            this.repoAward = repoAward;
            this.repoNominatie = repoNominatie;            
            this.repoJuryLid = repoJuryLid;            
            this.repoJuryKeuze = repoJuryKeuze;
            this.uow = uow;           
        }

        public void PostJuryKeuze(List<JuryKeuzeAwardVM> VMs)
        {
                     
        }
    }
}