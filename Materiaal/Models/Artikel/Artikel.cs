using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Materiaal.Models.Artikel
{
    public class Artikel
    {
        int art_Id { get; set; }
        string art_Naam { get; set; }
        int voorraad { get; set; }
        int cat_Id { get; set; }

    }
}