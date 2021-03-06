﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGamesDataTransfer.Models
{
    public class Country
    {
        public string CountryID { get; set; }
        public string Name { get; set; }
        public Game Game { get; set; }
        public Category Category { get; set; }
        public Sport Sport { get; set; }
        public string LogoImage { get; set; }
    }
}
