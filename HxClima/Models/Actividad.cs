using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClima.Models
{
    public class Actividad
    {
        public int ActividadID{ get; set; }
        public string Nombre { get; set; }
        public double TempMax { get; set; }
        public double TempMin { get; set; }
        public bool LluviaIndispensable{ get; set; }
    }   
}