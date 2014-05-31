using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class Sponsor
    {
        public int ID { get; set; }
        public String Naam { get; set; }
        public SponsorType Type { get; set; }
        public String Logo { get; set; }
        public String Beschrijving { get; set; }
        
    }
}