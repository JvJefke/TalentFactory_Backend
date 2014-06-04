using System;
using System.Collections.Generic;
using TalentFactory_Backend.DataAccess.Context;
using TalentFactory_Backend.DataAccess.Repositories;
using TalentFactory_Backend.Models;
namespace TalentFactory_Backend.DataAccess.Services
{
    public interface IContentService
    {
        Home GetHomeData();
        List<NieuwsItem> GetNieuwsItems(int startIndex, int iAantal);
        List<NieuwsItem> GetNieuwsItems();
        List<Sponsor> GetSponsors();
        List<Sponsor> GetSponsorsByType(int typeId);
        NieuwsItem GetNieuwsItemById(int nieuwsItemId);
        List<FlickrAlbum> GetFlickrAlbums();
        List<HallOfFame> GetHallOfFameElements();
        Contact GetContact();
        List<Award> GetAwards();
        List<Nominatie> GetNominatiesByAward(int awardId);
        List<Nominatie> GetNominatiesByAward(int awardId, int startIndex, int iAantal);
        List<Nominatie> GetNominaties();
    }
}
