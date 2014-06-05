using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_Backend.Models
{
    public class Felicitatie
    {
        public int ID { get; set; }
        public String Zender { get; set; }
        public String ZenderFoto { get; set; }
        public String Bericht { get; set; }
        public String Bron { get; set; }
        public String FotoBericht { get; set; }
        public int NominatieID { get; set; }
        public virtual Nominatie Nominatie { get; set; }
        public int AwardID { get; set; }
        public virtual Award Award { get; set; }
        public Boolean IsToegelaten { get; set; }
    }
}