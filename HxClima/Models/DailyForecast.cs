using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClimaWebApp.Models
{
    public class DailyForecast
    {
        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("EpochDate")]
        public int EpochDate { get; set; }

        [JsonProperty("Temperature")]
        public Temperature Temperature { get; set; }

        [JsonProperty("Day")]
        public Day Day { get; set; }

        [JsonProperty("Night")]
        public Night Night { get; set; }

        [JsonProperty("Sources")]
        public List<string> Sources { get; set; }

        [JsonProperty("MobileLink")]
        public string MobileLink { get; set; }

        [JsonProperty("Link")]
        public string Link { get; set; }
   }
}