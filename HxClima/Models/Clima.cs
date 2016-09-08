using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClima.Models
{
    public class Clima
    {
        public string Date { get; set; }
        public double tempMinima { get; set; }
        public double? tempMaxima { get; set; }
        public string fraseDia { get; set; }
        public string fraseNoche { get; set; }
    }
}