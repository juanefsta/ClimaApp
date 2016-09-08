using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClima.Models
{
    public class Minimum
    {
        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("UnitType")]
        public int UnitType { get; set; }
    }
}