using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClima.Models
{
    public class Actividad
    {
        [JsonProperty("ActividadId")]
        public int ActividadID{ get; set; }

        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("TempMax")]
        public double TempMax { get; set; }

        [JsonProperty("TempMin")]
        public double TempMin { get; set; }

        [JsonProperty("suspendePorLluvia")]
        public bool suspendePorLluvia { get; set; }
    }   
}