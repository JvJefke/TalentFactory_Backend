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
    public class ContentService : TalentFactory_Backend.DataAccess.Services.IContentService
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

        public ContentService(TFContext context, IGenericRepository<Award> repoAward, INominatieRepository repoNominatie, ISponsorRepository repoSponsor, INieuwsItemRepository repoNieuwsItem, IGenericRepository<Setup> repoSetup,
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
        }

        public Home GetHomeData()
        {
            return repoHome.All().FirstOrDefault();
        }

        public List<NieuwsItem> GetNieuwsItems(int startIndex, int iAantal)
        {
            return repoNieuwsItem.GetNieuwsItems(startIndex, startIndex + iAantal);
        }

        public List<NieuwsItem> GetNieuwsItems()
        {
            return repoNieuwsItem.All().ToList<NieuwsItem>();
        }

        public List<Sponsor> GetSponsors()
        {
            return repoSponsor.GetAlleSponsorsMetInclude();
        }

        public List<Sponsor> GetSponsorsByType(int typeId)
        {
            return repoSponsor.GetSponsorByType(typeId);
        }

        public NieuwsItem GetNieuwsItemById(int nieuwsItemId)
        {
            return repoNieuwsItem.GetByID(nieuwsItemId);
        }

        public List<FlickrAlbum> GetFlickrAlbums()
        {
            return repoFlickr.All().ToList<FlickrAlbum>();
        }

        public List<HallOfFame> GetHallOfFameElements()
        {
            return repoHallOfFame.All().ToList<HallOfFame>();
        }

        public Contact GetContact()
        {
            return repoContact.All().ToList<Contact>().FirstOrDefault();
        }

        public List<Award> GetAwards()
        {
            return repoAward.All().ToList<Award>();
        }

        public List<Nominatie> GetNominatiesByAward(int awardId)
        {
            return repoNominatie.GetNominatiesByAward(awardId);
        }

        public List<Nominatie> GetNominatiesByAward(int awardId, int startIndex, int iAantal)
        {
            return repoNominatie.GetNominatiesByIndex(awardId, startIndex, iAantal);
        }

        public List<Nominatie> GetNominaties()
        {
            return repoNominatie.All().ToList<Nominatie>();
        }

        public ContactAppVM GetContactAppVM()
        {
            ContactAppVM vm = new ContactAppVM();

            vm.Contact = GetContact();
            vm.setup = repoSetup.All().FirstOrDefault();

            return vm;
        }
        
    }
}