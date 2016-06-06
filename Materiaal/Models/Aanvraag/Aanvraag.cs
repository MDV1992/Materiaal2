using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Materiaal.Models.Aanvraag
{
    public class Aanvraag
    {
        public int aan_Id { get; set; }
        public string aan_Naam { get; set; }
        public DateTime aanvraag_Datum { get; set; }
        public DateTime Nodig_Datum { get; set; }
        public int code { get; set; }
        public int sta_Id { get; set; }
        public string aanvrager { get; set; }

    }
}