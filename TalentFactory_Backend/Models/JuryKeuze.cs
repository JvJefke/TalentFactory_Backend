using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class JuryKeuze
    {
        public int NominatieID { get; set; }
        [Key]

        public virtual Nominatie Nominatie { get; set; }
        [Key]
        public int Positie { get; set; }

        public int JuryLidId { get; set; }
        [Key]
        public virtual JuryLid JuryLid { get; set; }

    }
}