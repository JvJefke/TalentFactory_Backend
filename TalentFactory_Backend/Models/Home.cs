using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class Home
    {
        public int ID { get; set; }
        public String Inleiding { get; set; }
        public String AwardInfo { get; set; }
        public virtual List<TwitterFeed> TwitterFeeds { get; set; }
        public virtual List<FlickrAlbum> FlickrAlbums { get; set; }
    }
}