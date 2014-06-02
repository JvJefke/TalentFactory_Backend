using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using System.Data.Entity;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_Backend.DataAccess.Repositories;
using TalentFactory_Backend.Models;
using System.Web.Http;
using TalentFactory_Backend.DataAccess.UOW;
using TalentFactory_Backend.DataAccess.Services;

namespace TalentFactory_Backend
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<DbContext, TFContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<Award>, GenericRepository<Award>>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<Setup>, GenericRepository<Setup>>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<Contact>, GenericRepository<Contact>>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<HallOfFame>, GenericRepository<HallOfFame>>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<Home>, GenericRepository<Home>>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<JuryLid>, GenericRepository<JuryLid>>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<JuryKeuze>, GenericRepository<JuryKeuze>>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<Page>, GenericRepository<Page>>(new HierarchicalLifetimeManager());
            container.RegisterType<INominatieRepository, NominatieRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ISponsorRepository, SponsorRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<INieuwsItemRepository, NieuwsItemRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUOW, UOW>(new HierarchicalLifetimeManager());
            container.RegisterType<IContentService, ContentService>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenericRepository<FlickrAlbum>, GenericRepository<FlickrAlbum>>(new HierarchicalLifetimeManager());

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container)); 
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

        }
    }
}