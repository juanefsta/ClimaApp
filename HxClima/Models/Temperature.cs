using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClima.Models
{
    public class Temperature
    {
        [JsonProperty("Minimum")]
        public Minimum Minimum { get; set; }

        [JsonProperty("Maximun")]
        public Maximum Maximum { get; set; }
    }

}