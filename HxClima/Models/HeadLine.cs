using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HxClimaWebApp.Models
{
        public class Headline
        {
            [JsonProperty("EffectiveDate")]
            public string EffectiveDate { get; set; }

            [JsonProperty("EffectiveEpochDate")]
            public int EffectiveEpochDate { get; set; }

            [JsonProperty("Severity")]
            public int Severity { get; set; }

            [JsonProperty("Text")]
            public string Text { get; set; }

            [JsonProperty("Category")]
            public string Category { get; set; }

            [JsonProperty("EndDate")]
            public string EndDate { get; set; }

            [JsonProperty("EndEpochDate")]
            public int? EndEpochDate { get; set; }

            [JsonProperty("MobileLink")]
            public string MobileLink { get; set; }

            [JsonProperty("Link")]
            public string Link { get; set; }
        }
}