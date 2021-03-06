﻿using System;
using System.Collections.Generic;
using TalentFactory_Backend.Models;
namespace TalentFactory_Backend.DataAccess.Repositories
{
    public interface INominatieRepository : IGenericRepository<Nominatie>
    {
        System.Collections.Generic.List<TalentFactory_Backend.Models.Nominatie> GetNominatiesByAward(int id);
        System.Collections.Generic.List<TalentFactory_Backend.Models.Nominatie> GetNominatiesByAward(TalentFactory_Backend.Models.Award award);
        List<Nominatie> GetNominatiesByIndex(int awardId, int iStartIndex, int iAantal);

        // System.Collections.Generic.List<TalentFactory_CMS.Models.Nominatie> GetNominatiesByIndex(int iStartIndex, int iEindIndex);
    }
}
