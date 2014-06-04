using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.Models;

namespace TalentFactory_Backend.ViewModels
{
    public class JuryKeuzeAwardVM
    {
        public int AwardId { get; set; }
        public int JuryLidId { get; set; }
        public List<NominatiePositie> NominatiesPositie { get; set; }
    }
}