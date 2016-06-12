using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Materiaal.Models;
using System.Data.Entity.Infrastructure;

namespace Materiaal.DAL
{

        public class Initializer : DropCreateDatabaseIfModelChanges<Context>
        {
            protected override void Seed(Context context)
            {
            var Artikels = new List<Artikel>
            {
                new Artikel {art_Naam="Isoleerpot", cat_Id= 1, Leverancier="Hakrpo.nl", voorraad= 5, prijs= 165 },
                new Artikel {art_Naam="Pan Large", art_Id= 2, Leverancier="Pan en co", voorraad= 6, prijs= 45 },
                new Artikel {art_Naam="Schaar", art_Id= 3 , Leverancier="Krak", voorraad= 12, prijs= 8}
            };

            foreach (var tmp in Artikels)
            {
                context.Artikelen.Add(tmp);
            }
            var Categoriën = new List<Categorie>
            {
                new Categorie {cat_Naam="Voedselcontainer", Cat_Id= 1 },
                new Categorie {cat_Naam="Pannen", Cat_Id= 2 },
                new Categorie {cat_Naam="Klein materiaal", Cat_Id= 3 }
            };
            foreach (var tmp in Categoriën)
            {
                context.Categorien.Add(tmp);
            }
            }
       
        }
    }
