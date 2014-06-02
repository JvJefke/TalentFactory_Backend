using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_Backend.Models
{
    public class Award
    {
        public int ID { get; set; }
        public String Naam { get; set; }
        public String Logo { get; set; }
        public String Beschrijving { get; set; }

    }
}