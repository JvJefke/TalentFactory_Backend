using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class Contact
    {
        public int ID { get; set; }        
        public String Email { get; set; }
        public String Tel { get; set; }
        public String Straat_Nr { get; set; }
        public String Gemeente { get; set; }
        public String Postcode { get; set; }
        public String Land { get; set; }
        public String Foto1 { get; set; }
        public String Foto2 { get; set; }
        public String Foto3 { get; set; }
    }
}