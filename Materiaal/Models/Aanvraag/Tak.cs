using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Materiaal.Models.Aanvraag
{
    public class Tak
    {
        [Key]
        public int tak_Id { get; set; }
        [DisplayName("Tak naam:")]
        public string tak_Naam { get; set; }
    }
}