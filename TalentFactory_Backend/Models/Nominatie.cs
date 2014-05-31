using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class Nominatie
    {
        public int ID { get; set; }
        public String Voornaam { get; set; }
        public String Naam { get; set; }
        public String Email { get; set; }
        public String Tel { get; set; }
        public String Straat_Nr { get; set; }
        public String Gemeente { get; set; }
        public String Postcode { get; set; }
        public String Land { get; set; }
        public String RichtingId { get; set; }
        public virtual Richting Richting { get; set; }
        public String Beschrijving { get; set; }
        public String ExtraLinks { get; set; }
        public String Geslacht { get; set; }
        public int AwardId { get; set; }
        public virtual Award Award { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public String Key { get; set; }
        public Boolean IsActive { get; set; }
    }
}