using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Materiaal.Models
{
    public class Categorie
    {
        [Key]
       public int Cat_Id { get; set; }

        [DisplayName("Categorie")]
        public string cat_Naam { get; set; }
    }
}