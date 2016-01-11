using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Resa
    {
        public int ResaID { get; set; }

        [Required()]
        [Display(Name="Resmål")]
        public string ResMal { get; set; }

        public DateTime Start { get; set; }

        public DateTime Slut { get; set; }

        public string Berattelse { get; set; }

        public List<Image> Bilder { get; set; }
    }
}