using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClima.Models
{
    public class Json
    {
        [JsonProperty("days")]
        public List<Clima> climas { get; set; }

        [JsonProperty("cantidad")]
        public int dia { get; set; }

        [JsonProperty("actividad")]
        public object actividad;
    }
}