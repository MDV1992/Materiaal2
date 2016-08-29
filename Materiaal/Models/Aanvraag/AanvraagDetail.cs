using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Materiaal.Models.Aanvraag
{
    public class AanvraagDetail
    {
       public int det_Id { get; set; }
    
       public int aanvraag_Id { get; set; }
       public int artikel_Id { get; set; }
       public int aantal { get; set; }  
    }
}