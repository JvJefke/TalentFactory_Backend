using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.DataAccess.Repositories;
using TalentFactory_Backend.DataAccess.UOW;
using TalentFactory_Backend.Migrations;
using TalentFactory_Backend.Models;

namespace TalentFactory_Backend.DataAccess.Services
{
    public class FelicitatieService
    {
        private TFContext context = null;
        private IGenericRepository<Award> repoAward = null;
        private INominatieRepository repoNominatie = null;
        private ISponsorRepository repoSponsor = null;
        private INieuwsItemRepository repoNieuwsItem = null;
        private IGenericRepository<Setup> repoSetup = null;
        private IGenericRepository<Contact> repoContact = null;
        private IGenericRepository<HallOfFame> repoHallOfFame = null;
        private IGenericRepository<Home> repoHome = null;
        private IGenericRepository<JuryLid> repoJuryLid = null;
        private IGenericRepository<Page> repoPage = null;
        private IJuryKeuzeRepository repoJuryKeuze = null;
        private IGenericRepository<FlickrAlbum> repoFlickr = null;
        private IUOW uow;

        public FelicitatieService(TFContext context, IGenericRepository<Award> repoAward, INominatieRepository repoNominatie, ISponsorRepository repoSponsor, INieuwsItemRepository repoNieuwsItem, IGenericRepository<Setup> repoSetup,
         IGenericRepository<Contact> repoContact ,  IGenericRepository<HallOfFame> repoHallOfFame ,  IGenericRepository<Home> repoHome ,  IGenericRepository<JuryLid> repoJuryLid , IGenericRepository<Page> repoPage ,
        IJuryKeuzeRepository repoJuryKeuze, IGenericRepository<FlickrAlbum> repoFlickr, IUOW uow)
        {
            this.context = context;
            this.repoAward = repoAward;
            this.repoNominatie = repoNominatie;
            this.repoSponsor = repoSponsor;
            this.repoNieuwsItem = repoNieuwsItem;
            this.repoSetup = repoSetup;
            this.repoContact = repoContact;
            this.repoHallOfFame = repoHallOfFame;
            this.repoHome = repoHome;
            this.repoJuryLid = repoJuryLid;
            this.repoPage = repoPage;
            this.repoJuryKeuze = repoJuryKeuze;
            this.uow = uow;
            this.repoFlickr = repoFlickr;

            String Lisa = "Moet Leren!!!!!!";
        }


    }
}