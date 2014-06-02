using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_Backend.Models
{
    public class NieuwsItem
    {
        public int ID { get; set; }
        public String Titel { get; set; }
        public DateTime TimeOfRelease { get; set; }
        public String Foto { get; set; }
        public String Inleiding { get; set; }
        public String Artikel { get; set; }
    }
}