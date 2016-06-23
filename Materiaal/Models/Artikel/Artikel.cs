using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Materiaal.Models
{
    public class Artikel
    {
        [Key]
        public int art_Id { get; set; }
        [DisplayName("Artikel")]
        public string art_Naam { get; set; }
        [DisplayName("Voorraad")]
        public int voorraad { get; set; }
        [DisplayName("Categorie")]
        public int cat_Id { get; set; }
        [DisplayName("Prijs")]
        public double prijs { get; set; }
        [DisplayName("Leverancier")]
        public string Leverancier { get; set; }
        public virtual Categorie Categorie { get; set; }


    }
}