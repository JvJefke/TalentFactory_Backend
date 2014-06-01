using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class JuryKeuze
    {
        [Key]
        [Column(Order = 0)]
        public int NominatieID { get; set; }
        public virtual Nominatie Nominatie { get; set; }
        public int Positie { get; set; }
        [Key]
        [Column(Order = 1)]
        public int JuryLidId { get; set; }
        public virtual JuryLid JuryLid { get; set; }

    }
}