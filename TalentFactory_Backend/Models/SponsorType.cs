using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TalentFactory_Backend.Models
{
    public class SponsorType
    {
        public int ID { get; set; }
        public String Naam { get; set; }
        public int Order { get; set; }
    }
}