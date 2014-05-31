using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class Setup
    {
        public int ID { get; set; }
        public int Jaar { get; set; }
        public DateTime EventDateTime { get; set; }
        public String EventBride { get; set; }
        public String AccentKleur { get; set; }
        public String Logo { get; set; }
        public String Twitter { get; set; }
        public String Facebook { get; set; }
        public String Flickr { get; set; }
        public String GooglePlus { get; set; }

    }
}