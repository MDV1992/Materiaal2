using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Materiaal.Models;

namespace Materiaal.ViewModels.Artikels
{
    public class ArtikelIndexViewModel
    {
        public Categorie categorie = new Categorie();
        public Artikel artikel = new Artikel();

        //public int art_Id { get; set; }
        //[DisplayName("Artikel")]
        //public string art_Naam { get; set; }
        //[DisplayName("Voorraad")]
        //public int voorraad { get; set; }
        //[DisplayName("Categorie")]
        //public int cat_Id { get; set; }
        //[DisplayName("Prijs")]
        //public double prijs { get; set; }
        //[DisplayName("Leverancier")]
        //public string Leverancier { get; set; }
        //[DisplayName("Categorie")]
        //public string cat_Naam { get; set; }


    }
  
}