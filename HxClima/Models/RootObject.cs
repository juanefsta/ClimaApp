using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClimaWebApp.Models
{
    public class RootObject
    {
        [JsonProperty("Headline")]
        public Headline Headline { get; set; }

        [JsonProperty("DailyForecasts")]
        public List<DailyForecast> DailyForecasts { get; set; }

        
    }
}