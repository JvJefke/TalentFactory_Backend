﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TalentFactory_Backend.Models
{
    public class Richting
    {   
        [Key]
        public String Naam { get; set; }
    }
}