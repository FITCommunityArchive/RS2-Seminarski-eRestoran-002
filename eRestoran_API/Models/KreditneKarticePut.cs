﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eRestoran_API.Models
{
    public class KreditneKarticePut
    {
        public int KreditnaKarticaID { get; set; }
        public int KlijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int MjesecIsteka { get; set; }
        public int GodinaIsteka { get; set; }
        public string BrojKartice { get; set; }
        public string SigurnosniKod { get; set; }
    }
}