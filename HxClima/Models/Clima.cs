using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClima.Models
{
    public class Clima
    {
        
        public Clima(string fecha, double min,  int IconDia, int IconNoche)
        {

            date = fecha;
            tempMinima = min;
            iDia = IconDia;
            iNoche = IconNoche;
        }
        public string date { get; set; }
        public double tempMinima { get; set; }
        public double? tempMaxima { get; set; }
        public int iDia { get; set; }
        public int iNoche { get; set; }
    }
}