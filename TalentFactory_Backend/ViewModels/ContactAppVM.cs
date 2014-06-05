using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalentFactory_Backend.Models;

namespace TalentFactory_Backend.ViewModels
{
    public class ContactAppVM
    {
        public Contact Contact { get; set; }
        public Setup setup { get; set; }
    }
}