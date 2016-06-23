using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Materiaal.Models;

namespace Materiaal.ViewModels.Artikels
{
    public class ArtikelDetailViewModel
    {
        public Artikel artikel = new Artikel();

        public Categorie categorie = new Categorie();
    }
}