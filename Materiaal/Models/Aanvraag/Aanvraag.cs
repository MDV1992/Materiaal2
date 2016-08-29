using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Materiaal.Models.Aanvraag
{
    public class Aanvraag
    {
        public int aanvraag_Id { get; set; }
        public string aanvraag_Activiteit { get; set; }
        public DateTime aanvraag_Datum { get; set; }
        public DateTime nodig_Datum { get; set; }
        public int code { get; set; }
        public int stam_Id { get; set; }
        public string stam_Naam { get; set; }
        public string aanvrager { get; set; }

    }
}