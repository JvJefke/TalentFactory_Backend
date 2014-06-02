using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TalentFactory_Backend.Models
{
    public class HallOfFame
    {
        [Key]
        public int Jaartal { get; set; }
        public String HTMLInhoud { get; set; }
    }
}